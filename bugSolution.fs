let x = ref 1
let y = ref 2
let z () = !x + !y
printf "%d\n" (z())
x := 3
printf "%d\n" (z()) // z will now correctly print 5 because it is recalculated each time it's called.
