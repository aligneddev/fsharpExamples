// dotnet add package FSharp.Data --version 4.2.7
// https://fsprojects.github.io/FSharp.Data/library/HtmlParser.html
// https://mybinder.org/v2/gh/fsprojects/FSharp.Data/gh-pages?filepath=library/HtmlParser.ipynb
module fsharpExamples.Html

open FSharp.Data
open System.IO
open System.Text
open fSharpExamples.TypesAndObjects

// Helper functions I created to help with testing a generated Html Report
let parseHtml(reportHtml:string) = 
    let stream = new MemoryStream(Encoding.UTF8.GetBytes(reportHtml))
    let html = HtmlDocument.Load(stream)
    stream.Dispose();
    html

let loadData(fileName: string) = File.ReadAllText($"{fileName}.json")

let loadSnapshotHtml(fileName: string) = File.ReadAllText($"{fileName}.snapshot.html")
   
let stripHtmlForComparison(html: string) = html.ReplaceLineEndings("").Replace(" ", "")
let bodyOnly(htmlDoc: HtmlDocument) =
    htmlDoc.Body
    |> (fun b -> b.ToString())

let prepareForBodyComparison(html: string) =
    parseHtml html
    |> fun hd -> bodyOnly hd
    |> fun htmlString -> stripHtmlForComparison htmlString

// I haven't run this, so I'm not sure if it will all work
// this should be typed to return a list
let toPersonList(json: string) = Newtonsoft.Json.JsonConvert.DeserializeObject<Person> json

// load the 
let snapshotHtml = loadSnapshotHtml "reportSample"
let html = parseHtml snapshotHtml

let totalCellsText = 
        html.CssSelect ".totals"
        |> Seq.head
        |> (fun td -> td.Descendants ["div"])
        |> Seq.map(fun d -> d.InnerText())
        |> Seq.toArray