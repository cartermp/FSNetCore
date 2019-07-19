module Tests

open Xunit

[<Fact>]
let ``Test Hello`` () =
    let expected = """I used to be Hello but now I'm "Hello" thanks to JSON.NET!"""
    let actual = Library.getJsonNetJson "Hello"
    Assert.Equal(expected, actual)
