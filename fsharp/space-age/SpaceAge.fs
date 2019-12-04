module SpaceAge

// TODO: define the Planet type
type Planet =
| Earth
| Mercury
| Venus
| Mars
| Jupiter
| Saturn
| Uranus
| Neptune

let getPlanetAge planet =
    let earthYearSeconds = 31557600.0
    match planet with
    | Earth ->  earthYearSeconds
    | Mercury ->  earthYearSeconds *  0.2408467
    | Venus -> earthYearSeconds * 0.61519726
    | Mars ->  earthYearSeconds * 1.8808158
    | Jupiter -> earthYearSeconds * 11.862615
    | Saturn -> earthYearSeconds * 29.447498
    | Uranus ->  earthYearSeconds * 84.016846
    | Neptune ->  earthYearSeconds * 164.79132

let age (planet: Planet) (seconds: int64): float = 
    match planet with
    | Earth -> float (seconds) / getPlanetAge planet
    | Mercury -> float (seconds) / getPlanetAge planet
    | Venus -> float (seconds) / getPlanetAge planet
    | Mars -> float (seconds) / getPlanetAge planet
    | Jupiter -> float (seconds) / getPlanetAge planet
    | Saturn -> float (seconds) / getPlanetAge planet
    | Uranus -> float (seconds) / getPlanetAge planet
    | Neptune -> float (seconds) / getPlanetAge planet