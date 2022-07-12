# BlogProject
Blog project(layered architectural) with Entity Framework Core


BLOG PROJECT - 
	Blank Solution
		* Solution => MODELS layer, Class Library
		* MODELS => Entities => Abstract ve Concrete folders.

		* MODELS => Enums
		* MODELS => EntityTypeConfiguration (for database relation/tables)

		* Note => I downloaded the EF CORE.HTTP.FEATURES package for the IFormFile property

		* Note => I downloaded the Microsoft.Extensions.Identity.Stores package for IdentityRole

		* I used the Mic.EFCORE.SQL SERVER package for the configurations.

		*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	

		2. DataAccessLayer(Repository and Context)
			
			*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	*	**		*	*	*	*	*	*	*	*	*

		3. WEB layer/(User Interface(UI)) asp.net core web app (mvc)

			add-migration name followed by update-database

			* Areas folders. => Member and Admin

			* I used Identity library in the project


			* Note => For the Mapper library => AutoMapper + AutoMapper.Extetions.MIC.
