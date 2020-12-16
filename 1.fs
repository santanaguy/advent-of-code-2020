let lines = System.IO.File.ReadLines(".\\1.txt")
            |> List.ofSeq
            |> List.map int32

let r = lines 
        |> List.indexed
        |> List.fi(fun (idx,v) -> 
                                let found = lines.[idx+1 .. ] 
                                                |> List.tryFind (fun b -> b + v = 2020)
                                                |> Option.bind (fun b -> Some (b * v))
                                match found with
                                |> Some b -> b * v
                                |> 
                                )
        



//fuck this