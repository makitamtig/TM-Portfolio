namespace TamToum.Models.ViewModel
{


	public class PortfolioViewModel
	{
		public List<PortfolioProjectViewModel> Projects { get; set; } = new();
	}

	public class PortfolioProjectViewModel
	{
		public string Number { get; set; } = string.Empty;

		public string Title { get; set; } = string.Empty;

		public string Category { get; set; } = string.Empty;

		public string Description { get; set; } = string.Empty;

		public string CoverImage { get; set; } = string.Empty;

		public List<string> Technologies { get; set; } = new();

		public List<PortfolioVideoViewModel> Videos { get; set; } = new();

		public List<PortfolioImageViewModel> Images { get; set; } = new();
		//public List<string> Images { get; set; } = new();
	}



	public class PortfolioImageViewModel
	{
		public string Title { get; set; } = string.Empty;
		public string Url { get; set; } = string.Empty;
	}


	public class PortfolioVideoViewModel
	{
		public string Title { get; set; } = string.Empty;

		public string Url { get; set; } = string.Empty;

		public string? Poster { get; set; }

	}

}
