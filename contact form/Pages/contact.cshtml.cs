using Microsoft.AspNetCore.Mvc.RazorPages;

namespace contact_form.Pages
{
	public class contactModel : PageModel
    {

        public bool hasdata=false;
        public string firstname = "";
		public string lastname = "";
		public string message = "";

		public void OnGet()
        {
        }

        public void OnPost() 
        {



		       hasdata = true;
               firstname = Request.Form["firstname"];
	           lastname = Request.Form["lastname"]; 
		       message = Request.Form["subject"]; 



	}


}
}
