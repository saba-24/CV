namespace mvc_test.Models
{
	public class Edu
	{
		public required string name { get; set; }
		public int startDate { get; set; }
		public int? endDate { get; set; }
		public float? GPA { get; set; }
		public string? major { get; set; }

	}
}
