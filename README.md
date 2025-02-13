# F# Immutability Bug

This example demonstrates a potential point of confusion for those new to F#. In F#, values are immutable by default.  This means once a value is computed, it remains constant, even if the variables it depends on are later modified.  This can lead to unexpected behavior if you're not aware of this characteristic.

The `bug.fs` file contains the code illustrating this issue.  The `bugSolution.fs` shows how to work around this limitation, usually by using functions to recalculate dependent values.