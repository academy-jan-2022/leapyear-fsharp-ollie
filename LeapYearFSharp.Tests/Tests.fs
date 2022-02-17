module Tests

open System
open Xunit

[<Theory>]
[<InlineData(1, false)>]
[<InlineData(2, false)>]
[<InlineData(3, false)>]
[<InlineData(4, true)>]
[<InlineData(8, true)>]
let ``Check is leap year`` input expected =
    let result = LeapYear.Check input
    Assert.Equal(expected, result)