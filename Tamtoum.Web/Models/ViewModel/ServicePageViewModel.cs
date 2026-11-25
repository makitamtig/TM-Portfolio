namespace TamToum.Models.ViewModel
{

		public class ServicePageViewModel
		{
			public string Title { get; set; } = "";
			public string Subtitle { get; set; } = "";
			public string Description { get; set; } = "";
			public string HeroLabel { get; set; } = "";

			public string OverviewTitle { get; set; } = "";
			public string Overview { get; set; } = "";

			public string WhyTitle { get; set; } = "What We Deliver";

			public List<string> Features { get; set; } = new();
			public List<string> Benefits { get; set; } = new();
			public List<string> Process { get; set; } = new();
			public List<string> Technologies { get; set; } = new();

			public string ClosingTitle { get; set; } = "";
			public string ClosingDescription { get; set; } = "";

			public List<ServiceLink> RelatedServices { get; set; } = new();
		}

		public class ServiceLink
		{
			public string Title { get; set; } = "";
			public string Action { get; set; } = "";
		}
	}
