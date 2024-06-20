
public class Reservation
{
	public int TableNumber {  get; set; }
    public string  CustomerName { get; set; }
	public string TimeSlot {  get; set; }

    public Reservation(int tableNumber, 
        string customerName, string timeSlot)
    {
		TableNumber = tableNumber;
		CustomerName = customerName;
		TimeSlot = timeSlot;
	}

	public override string ToString()
	{
		return $"Table {TableNumber}:{CustomerName} at " +
			$"{TimeSlot}";
	}
}
