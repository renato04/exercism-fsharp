module RobotName
let random = System.Random()

type Robot = { Name: string}

let letters = ['A' .. 'Z']
let maxNumber = 1000

let mutable CreatedNames = Set.empty<string>

let getRandomName ()=
    let getRandomLetter =
        string(letters.Item (random.Next letters.Length)) +
        string(letters.Item (random.Next letters.Length))
    let getRandomNumber =
        string(random.Next maxNumber)
    
    getRandomLetter + getRandomNumber

let getUniqueName () =
    let rec getUniqueName () =
        let newName = getRandomName ()
        if CreatedNames.Contains newName then
            getUniqueName ()
        else
            newName

    let name = getUniqueName ()
    CreatedNames <- CreatedNames |> Set.add name

    name
    
let createRobot () = {Name= getUniqueName ()}

let mkRobot() = createRobot ()

let name robot = robot.Name

let reset robot = 
    let newName = getUniqueName ()

    CreatedNames <- CreatedNames |> Set.remove robot.Name

    { robot with Name = newName }
