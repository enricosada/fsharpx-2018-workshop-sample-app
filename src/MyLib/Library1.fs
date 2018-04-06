module MyLibrary

open System

let helloMessage name =
    sprintf "Hello %s" name

let downloadFrom url = async {
    use wc = new System.Net.WebClient()
#if NETSTANDARD2_0
    return wc.DownloadString (Uri(url))
#else
    //this is needed in .NET 4.5.2 because it use an old tls version in the example github website
    //ask Steffen Forkmann for a funny story about it 
    System.Net.ServicePointManager.SecurityProtocol <- System.Net.SecurityProtocolType.Tls12
    return! wc.AsyncDownloadString (Uri(url))
#endif
}
