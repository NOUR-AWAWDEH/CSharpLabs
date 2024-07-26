

var reservationSystem = new ReservationSystem();

Console.WriteLine(reservationSystem.AddReservation(1, "Alex", "18:00"));

Console.WriteLine(reservationSystem.AddReservation(2, "Ahmed", "19:00"));

//Should fail!!
Console.WriteLine(reservationSystem.AddReservation(1, "Aristote", "18:00"));

Console.WriteLine(reservationSystem.ViewReservations());

Console.WriteLine(reservationSystem.CancelReservation(1, "18:00"));

Console.WriteLine(reservationSystem.ViewReservations());
 
/*
My Approach To Solve the task :
 
 1. Add a Reservation:
    • Input: AddReservation(1, "Alice", "18:00")
    • Output: Reservation added for Alice at table 1 for 18:00.
 2. Cancel a Reservation:
    • Input: CancelReservation(1, "18:00")
    • Output: Reservation for table 1 at 18:00 has been canceled.
 3. View Reservations:
    • Input: ViewReservations()
    • Output:sqlCopy code  Current Reservations:
        • Table 1: Alice at 18:00
        • Table 2: Bob at 19:00
 */