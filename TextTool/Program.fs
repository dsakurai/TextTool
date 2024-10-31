// For more information see https://aka.ms/fsharp-console-apps

open System
open System.Net

Console.Write("Enter text: ")

let originalString           =  Console.ReadLine() // Get user input, like "text@domain"
let webEncodedString: string = WebUtility.UrlEncode(originalString)

printfn "%s" webEncodedString