using System;

Seat seat1 = new Seat("김민수");
Seat seat2 = new Seat("이지영");
Seat seat3 = new Seat("박서준");

seat1.Study();
seat2.Study();
seat3.Study();

Seat.ShowStatus();

seat1 = null;
seat2 = null;
seat3 = null;

GC.Collect();
GC.WaitForPendingFinalizers();

Seat.ShowStatus();