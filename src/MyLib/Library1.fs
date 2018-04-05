module MyLibrary

open System

let helloMessage name =
    sprintf "Hello %s" name

let downloadFrom url = async {
    use wc = new System.Net.WebClient()
    return! wc.AsyncDownloadString (Uri(url))
}
