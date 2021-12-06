namespace AdventOfCode.Models {
	public  class HttpResult {
		public bool IsSuccessful { get; set; }
		public string Response { get; set; }
		public string ExceptionMessage { get; set; }
	}
}
