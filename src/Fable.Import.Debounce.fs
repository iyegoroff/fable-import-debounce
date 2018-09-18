module Fable.Import.Debounce

open Fable.Core

type IDebounced<'f> =
  interface end

[<Import("default", "debounce"); Emit("$0($1, $2, $3)")>]
let debounce<'f> (_f: 'f) (_interval: int) (_immediate: bool) : IDebounced<'f> = jsNative

[<Emit("$0")>]
let unwrap (_debounced: IDebounced<'f>): 'f = jsNative

[<Emit("$0.clear()")>]
let clear (_debounced: IDebounced<'f>): unit = jsNative
