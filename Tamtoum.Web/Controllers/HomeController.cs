using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TamToum.Models.ViewModel;
using TamToum.Web.Models;

namespace TamToum.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


		public IActionResult Index()
		{
			var model = new PortfolioViewModel
			{
				Projects = new List<PortfolioProjectViewModel>
		{
			new PortfolioProjectViewModel
			{
				Number = "01",
				Title = "Tamtoum Jewels",
				Category = "E-COMMERCE PLATFORM",

				Description =
					"A full-stack jewelry e-commerce platform " +
					"featuring product management, customization, " +
					"secure checkout, inventory, order management, " +
					"and automated email communication.",

				//CoverImage = "/Images/Projects/main.png",

				Technologies = new List<string>
				{
					"ASP.NET Core MVC",
					"C#",
					"SQL Server",
					"Entity Framework",
					"Stripe"
				},

				Videos = new List<PortfolioVideoViewModel>
				{
					new PortfolioVideoViewModel
					{
						Title = "Platform Overview",
						Url = "/Videos/Tour1.mp4",
						Poster = "/Images/Projects/MainT.png"
					},

					new PortfolioVideoViewModel
					{
						Title = "Product Customization",
						Url = "/Videos/Customization.mp4",
						Poster = "/Images/Projects/customization.png"
					},

					new PortfolioVideoViewModel
					{
						Title = "Review & Reorder",
						Url = "/Videos/Review&Reorder.mp4",
						Poster = "/Images/Projects/Reviews.png"
					},

					new PortfolioVideoViewModel
					{
						Title = "Admin Dashboard & Order Management",
						Url = "/Videos/AdminDashboard.mp4",
						Poster = "/Images/Projects/CreateProduct.png"
					}
				},

			Images = new List<PortfolioImageViewModel>
{
	new PortfolioImageViewModel { Title = "Main Landing Page", Url = "/Images/Projects/MainT.png" },
	new PortfolioImageViewModel { Title = "Product Customization", Url = "/Images/Projects/customization.png" },
	new PortfolioImageViewModel { Title = "Manage Products Dashboard", Url = "/Images/Projects/ManageProduct.png" },
	new PortfolioImageViewModel { Title = "Create New Product", Url = "/Images/Projects/CreateProduct.png" },
	new PortfolioImageViewModel { Title = "Product Details Page", Url = "/Images/Projects/Products.png" },
		new PortfolioImageViewModel { Title = "Product Details Page", Url = "/Images/Projects/Categories.png" },
	new PortfolioImageViewModel { Title = "Homepage Slider Management", Url = "/Images/Projects/Sliders.png" },
		new PortfolioImageViewModel { Title = "Homepage Slider Management", Url = "/Images/Projects/Filter.png" },
			new PortfolioImageViewModel { Title = "Homepage Slider Management", Url = "/Images/Projects/Search.png" },
				//new PortfolioImageViewModel { Title = "Collections Showcase", Url = "/Images/Projects/Collection.png" },
	new PortfolioImageViewModel { Title = "Customer Reviews", Url = "/Images/Projects/Reviews.png" },
	new PortfolioImageViewModel { Title = "Order Confirmation", Url = "/Images/Projects/OConfirmation.png" },
	new PortfolioImageViewModel { Title = "Shopping Cart", Url = "/Images/Projects/ShoppingCart.png" },
	new PortfolioImageViewModel { Title = "Payment Checkout Page", Url = "/Images/Projects/Payment.png" }
}

			}
		}
			};

			return View(model);
		}
		//      public IActionResult Index()
		//      {
		//	var model = new PortfolioViewModel
		//	{
		//		Projects = new List<PortfolioProjectViewModel>
		//{
		//          // PROJECT 01
		//          new PortfolioProjectViewModel
		//	{
		//		Number = "01",
		//		Title = "Tm Jewels",
		//		Category = "E-COMMERCE PLATFORM",

		//		Description =
		//			"A full-stack jewelry e-commerce platform " +
		//			"featuring product management, customization, " +
		//			"secure checkout, inventory, order management, " +
		//			"and automated email communication.",

		//		CoverImage = "/Images/Projects/main.png",

		//		Technologies = new List<string>
		//		{
		//			"ASP.NET Core MVC",
		//			"C#",
		//			"SQL Server",
		//			"Entity Framework",
		//			"Stripe"
		//		},

		//		Videos = new List<PortfolioVideoViewModel>
		//		{
		//			new PortfolioVideoViewModel
		//			{
		//				Title = "Platform Overview",
		//				Url = "/Videos/FinalTour.mp4",
		//				Poster = "/Images/main.png"
		//			},

		//			new PortfolioVideoViewModel
		//			{
		//				Title = "Product Customization",
		//				Url = "/Videos/LatestCustomization.mp4",
		//				Poster = "/Images/main.png"
		//			},

		//			new PortfolioVideoViewModel
		//			{
		//				Title = "Review & Reorder",
		//				Url = "/Videos/Review&Reorder.mp4",
		//				Poster = "/Images/main.png"
		//			},

		//			new PortfolioVideoViewModel
		//			{
		//				Title = "Admin Dashboard & Order Management",
		//				Url = "/Videos/AdminDashboard.mp4",
		//				Poster = "/Images/Projects/tm-dashboard.jpg"
		//			}
		//		},

		//		Images = new List<string>
		//		{
		//			"/Images/Projects/main.png",
		//			"/Images/Projects/OtherCustomization.png",
		//			"/Images/Projects/rings.png",
		//			"/Images/Projects/Shoppingcart.png"
		//		}
		//	},

		//			// PROJECT 02
		//			//         new PortfolioProjectViewModel
		//			//{
		//			//	Number = "02",
		//			//	Title = "Project Title",
		//			//	Category = "WEB APPLICATION",
		//			//	Description = "Add your project description here.",

		//			//			CoverImage = "",

		//			//			Technologies = new List<string>(),

		//			//			Videos = new List<PortfolioVideoViewModel>(),

		//			//			Images = new List<string>()
		//			//		},

		//			//		         // PROJECT 03
		//			//		         new PortfolioProjectViewModel
		//			//		{
		//			//			Number = "03",
		//			//			Title = "Project Title",
		//			//			Category = "SOFTWARE SOLUTION",
		//			//			Description = "Add your project description here.",

		//			//			CoverImage = "",

		//			//			Technologies = new List<string>(),

		//			//			Videos = new List<PortfolioVideoViewModel>(),

		//			//			Images = new List<string>()
		//			//		},

		//			//		         // PROJECT 04
		//			//		         new PortfolioProjectViewModel
		//			//		{
		//			//			Number = "04",
		//			//			Title = "Project Title",
		//			//			Category = "DIGITAL EXPERIENCE",
		//			//			Description = "Add your project description here.",

		//			//			CoverImage = "",

		//			//			Technologies = new List<string>(),

		//			//			Videos = new List<PortfolioVideoViewModel>(),

		//			//			Images = new List<string>()
		//			//		}

		//			//		         // Add additional projects here.
		//			//		     
		//		}
		//	};

		//	return View(model);
		//}
		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
