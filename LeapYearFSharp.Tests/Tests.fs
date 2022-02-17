module Tests

open System
open Xunit

[<Theory>]
[<InlineData(1, false)>]
let ``Check is leap year`` input expected =
    let result = LeapYear.Check input
    Assert.Equal(expected, result)