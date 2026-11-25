using Microsoft.AspNetCore.Mvc;
using TamToum.Models.ViewModel;

namespace TamToum.Controllers
{
	public class ServicesController : Controller
	{
		
		

			private readonly List<ServiceLink> allServices = new()
		{
			new() { Title = "Website Development", Action = "WebsiteDevelopment" },
			new() { Title = "E-commerce Development", Action = "EcommerceDevelopment" },
			new() { Title = "Web Applications", Action = "WebApplications" },
			new() { Title = "UI/UX & Responsive Design", Action = "UIDesign" },
			new() { Title = "API & Integrations", Action = "APIIntegrations" },
			new() { Title = "Maintenance & Optimization", Action = "Maintenance" }
		};

			private ServicePageViewModel CreatePage(
				string title,
				string subtitle,
				string description,
				string label,
				string overviewTitle,
				string overview,
				List<string> features,
				List<string> benefits,
				List<string> process,
				List<string> technologies,
				string closingTitle,
				string closingDescription)
			{
				return new ServicePageViewModel
				{
					Title = title,
					Subtitle = subtitle,
					Description = description,
					HeroLabel = label,
					OverviewTitle = overviewTitle,
					Overview = overview,
					Features = features,
					Benefits = benefits,
					Process = process,
					Technologies = technologies,
					ClosingTitle = closingTitle,
					ClosingDescription = closingDescription,
					RelatedServices = allServices
	.Where(s => s.Action !=
		(string?)ControllerContext.RouteData.Values["action"])
	.Take(3)
	.ToList()
				};
			}


		public IActionResult WebsiteDevelopment()
		{
			return View(CreatePage(
				"Professional Website Development",
				"Modern websites. Meaningful digital experiences.",
				"At Tamtoum, we design and develop custom websites that bring your ideas to life. From corporate websites and professional portfolios to fully customized web solutions, we build responsive, user-friendly and scalable digital experiences that help businesses establish their online presence and achieve their goals.",

				"01 / WEBSITE DEVELOPMENT",

				"Websites Built Around Your Vision",
				"Your website is often the first interaction customers have with your business. It should communicate your identity, showcase your services and make every interaction simple and meaningful. We combine modern design, clean development practices and reliable technologies to create websites that look professional, perform smoothly and grow with your business.",

				new()
				{
			"Corporate and business website development",
			"Professional personal and creative portfolios",
			"Landing pages and promotional websites",
			"Custom multi-page website development",
			"Responsive and mobile-first web design",
			"Content management and dynamic functionality",
			"Secure contact forms and interactive features",
			"SEO-friendly structure and optimized page architecture"
				},

				new()
				{
			"A strong and professional digital identity",
			"Improved user experience and navigation",
			"Responsive layouts across all devices",
			"Fast, reliable and maintainable websites",
			"Scalable architecture for future growth",
			"Search-engine-friendly foundations"
				},

				new()
				{
			"Understanding your business and requirements",
			"Planning the website structure and content",
			"Creating the visual design and user experience",
			"Developing the website and its functionality",
			"Testing responsiveness, performance and compatibility",
			"Final review, deployment and launch"
				},

				new()
				{
			"ASP.NET Core MVC",
			"C#",
			"Razor Views",
			"HTML5 & CSS3",
			"JavaScript",
			"Bootstrap",
			"SQL Server"
				},

				"Let's Build Your Digital Presence",
				"Whether you are launching a new business or improving your existing online presence, we create websites that combine thoughtful design, practical functionality and reliable technology. Let's turn your vision into a professional digital experience."
			));
		}

		public IActionResult EcommerceDevelopment()
			{
				return View(CreatePage(
					"E-commerce Development",
					"Complete online shopping experiences.",
					"We develop tailored e-commerce platforms that help businesses present products, manage orders and deliver smooth online shopping experiences.",
					"02 / E-COMMERCE",
					"More Than Just an Online Store",
					"A successful online store needs more than attractive product pages. It requires a reliable shopping experience, secure payments, inventory management and efficient order processing. We build integrated e-commerce solutions around these needs.",
					new()
					{
					"Custom online storefronts",
					"Product catalogs and categories",
					"Product variations and customization",
					"Shopping carts and checkout systems",
					"Payment gateway integration",
					"Customer registration and accounts",
					"Order tracking and management",
					"Inventory and stock management",
					"Administrative dashboards",
					"Automated email notifications"
					},
					new()
					{
					"Smooth customer shopping journeys",
					"Secure payment workflows",
					"Centralized order management",
					"Flexible product management",
					"Mobile-friendly shopping experiences"
					},
					new()
					{
					"Store requirements and planning",
					"Product and category architecture",
					"Storefront design",
					"Cart and checkout development",
					"Payment integration and testing",
					"Order workflow validation",
					"Final testing and deployment"
					},
					new()
					{
					"ASP.NET Core MVC",
					"C#",
					"Entity Framework Core",
					"SQL Server",
					"Stripe Integration",
					"HTML, CSS & JavaScript",
					"REST APIs"
					},
					"Build an Online Store That Works",
					"From product presentation to payment processing, every part of the shopping experience should work together seamlessly."
				));
			}

			public IActionResult WebApplications()
			{
				return View(CreatePage(
					"Web Applications & Business Systems",
					"Powerful applications designed around real workflows.",
					"We build custom web applications that simplify operations, organize information and help businesses manage their everyday processes.",
					"03 / WEB APPLICATIONS",
					"Turn Complex Processes Into Simple Systems",
					"Different businesses have different operational requirements. We develop tailored applications that replace repetitive manual work with organized, accessible and efficient digital systems.",
					new()
					{
					"Administrative dashboards",
					"Customer and employee portals",
					"Booking and reservation systems",
					"Inventory management applications",
					"Order and workflow management",
					"Role-based user authentication",
					"Reporting and analytics dashboards",
					"Database-driven applications",
					"Automated business workflows"
					},
					new()
					{
					"Centralized business information",
					"More efficient workflows",
					"Reduced repetitive tasks",
					"Secure access and permissions",
					"Flexible and scalable architecture"
					},
					new()
					{
					"Business workflow analysis",
					"Application architecture planning",
					"Database design",
					"Interface and dashboard development",
					"Backend implementation",
					"Testing and security review",
					"Deployment and improvements"
					},
					new()
					{
					"C#",
					"ASP.NET Core MVC",
					"Entity Framework Core",
					"SQL Server",
					"LINQ",
					"Identity Authentication",
					"JavaScript"
					},
					"Technology That Simplifies Your Business",
					"We focus on applications that solve practical problems, improve organization and support the way businesses actually operate."
				));
			}

			public IActionResult UIDesign()
			{
				return View(CreatePage(
					"UI/UX & Responsive Design",
					"Thoughtful interfaces. Better digital experiences.",
					"We design intuitive, visually consistent and responsive interfaces that make websites and applications easier and more enjoyable to use.",
					"04 / UI & UX DESIGN",
					"Design That Connects Function and Appearance",
					"A successful interface should look professional while making navigation and interaction effortless. We combine visual consistency, responsive layouts and user-focused design principles to create meaningful digital experiences.",
					new()
					{
					"Website interface design",
					"Application dashboard interfaces",
					"Mobile-first responsive layouts",
					"Navigation and information architecture",
					"Typography and visual hierarchy",
					"Consistent color and design systems",
					"Interactive interface elements",
					"Cross-device layout improvements",
					"Accessibility-conscious design"
					},
					new()
					{
					"Clearer website navigation",
					"Consistent visual identity",
					"Improved usability",
					"Better mobile experiences",
					"Professional presentation"
					},
					new()
					{
					"Understanding the target audience",
					"Planning the user journey",
					"Organizing content and navigation",
					"Developing the visual direction",
					"Building responsive interfaces",
					"Reviewing and refining the experience"
					},
					new()
					{
					"HTML5",
					"CSS3",
					"Bootstrap",
					"JavaScript",
					"Razor",
					"Responsive Web Design",
					"Accessibility Principles"
					},
					"Create Experiences People Enjoy Using",
					"Every detail matters, from the first impression to the smallest interaction. We aim to make every interface clear, consistent and purposeful."
				));
			}

			public IActionResult APIIntegrations()
			{
				return View(CreatePage(
					"API Development & Integrations",
					"Connecting applications, services and data.",
					"We develop and integrate APIs that allow applications and external services to communicate securely and efficiently.",
					"05 / API & INTEGRATIONS",
					"Make Your Systems Work Together",
					"Modern applications often depend on multiple services. We build API-driven functionality and integrate external platforms to connect systems, exchange information and automate important operations.",
					new()
					{
					"Custom REST API development",
					"Third-party API integration",
					"Payment gateway connections",
					"Email service integration",
					"External data synchronization",
					"JSON data processing",
					"Authentication and authorization",
					"API validation and error handling",
					"Database-connected endpoints"
					},
					new()
					{
					"Connected digital services",
					"Reliable data exchange",
					"Reduced manual operations",
					"Secure application communication",
					"More flexible system architecture"
					},
					new()
					{
					"Integration requirements analysis",
					"API architecture planning",
					"Endpoint development",
					"Authentication implementation",
					"External service integration",
					"Testing and validation",
					"Documentation and deployment"
					},
					new()
					{
					"ASP.NET Core Web API",
					"C#",
					"REST",
					"JSON",
					"HTTP",
					"SQL Server",
					"Entity Framework Core"
					},
					"Connect Your Digital Ecosystem",
					"From payment providers to external business platforms, integrations help create a more connected and efficient application environment."
				));
			}

			public IActionResult Maintenance()
			{
				return View(CreatePage(
					"Website Maintenance & Optimization",
					"Keeping digital experiences reliable and performing.",
					"We improve existing websites and applications through technical maintenance, performance enhancements, troubleshooting and ongoing optimization.",
					"06 / MAINTENANCE",
					"Your Website Should Keep Moving Forward",
					"Launching a website is only one stage of its lifecycle. Regular maintenance helps keep applications stable, secure, efficient and compatible with changing requirements.",
					new()
					{
					"Website bug fixing",
					"Performance optimization",
					"Database query improvements",
					"Security and dependency updates",
					"Responsive layout corrections",
					"Code cleanup and refactoring",
					"Application troubleshooting",
					"Feature enhancements",
					"Technical compatibility reviews"
					},
					new()
					{
					"Improved website performance",
					"More reliable functionality",
					"Better code maintainability",
					"Reduced technical issues",
					"A stronger foundation for future growth"
					},
					new()
					{
					"Reviewing the existing application",
					"Identifying technical issues",
					"Prioritizing improvements",
					"Implementing corrections",
					"Testing updated functionality",
					"Reviewing overall performance"
					},
					new()
					{
					"ASP.NET Core",
					"C#",
					"SQL Server",
					"Entity Framework Core",
					"HTML & CSS",
					"JavaScript",
					"Performance Optimization"
					},
					"Keep Your Digital Platform at Its Best",
					"A well-maintained application is easier to use, manage and improve. We focus on practical technical enhancements that support long-term reliability."
				));


			}

		public IActionResult Index()
		{
			return View();
		}
	}
	}
