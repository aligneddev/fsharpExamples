
// dotnet add package Newtonsoft.Json 
// https://atlemann.github.io/fsharp/2021/12/11/fs-crypto.html has more examples
module fSharpExamples.Json

type Person = { name : string; hobbies : string[] }

let loadData(fileName: string) = System.IO.File.ReadAllText(fileName)
let toPersonModel(json: string) = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(json)



let blendReportModel = 
  loadData("people.json")
  |> (fun json -> toPersonModel(json))
