module Fable.Import.Debounce

open Fable.Core

[<Import("default", "debounce"); Emit("$0($1, $2, $3)")>]
let debounce<'f> (_f: 'f) (_interval: int) (_immediate: bool) : 'f = jsNative
