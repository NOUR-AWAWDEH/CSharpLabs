
public class ReservationSystem
{
	// in-memory database
	private List<Reservation> reservations = new List<Reservation>();

	// Add method
	public string AddReservation(int tableNumber, 
		string customerName, string timeSlot)
	{
		if(reservations.Any(r => r.TableNumber == tableNumber 
			&& r.TimeSlot == timeSlot))
		{
			return $"Table{tableNumber} is already booked for {timeSlot}";
		}

		reservations.Add(new Reservation(tableNumber, customerName, timeSlot));

		return $"Reservation added for {customerName} at table {tableNumber} for {timeSlot}";
	}

	// cancel reservation method
	public string CancelReservation(int tableNumber, string timeSlot)
	{
		var reservation = reservations.FirstOrDefault(r => 
			r.TableNumber == tableNumber && r.TimeSlot == timeSlot);

		if(reservation is not null)
		{
			reservations.Remove(reservation);

			return $"Reservation for table {tableNumber} at {timeSlot} has been canceled";
		}

		return $"No reservation found for table {tableNumber} at {timeSlot}";
	}

	// View reservation method(view all the reservations)
	public string ViewReservations()
	{
		if(reservations.Count == 0)
		{
			return "No current reservations";
		}

		return "Current reservations:\n" + string.Join("\n", reservations);
	}
}

