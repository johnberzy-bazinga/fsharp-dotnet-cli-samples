open Xunit
open Library
module Foo =
    
    [<Fact>]
    let passing () = Assert.Equal("Hello coreclr", Say.hello "coreclr")


    [<Fact>]
    let failing () = Assert.Equal("hello coreclr", Say.hello "coreclr")