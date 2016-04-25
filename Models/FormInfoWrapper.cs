using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ingeniux.Runtime.Models
{
	public class FormInfoWrapper
	{
		#region Static Members
		private static StelterFormsDataContext dc;

		static FormInfoWrapper()
		{
			dc = new StelterFormsDataContext();
		}
		#endregion

		public void AddFormSubmission(String CustomerName, String ReferringUrl, String FormName, String PageName, String FirstName, String LastName, String EmailAddress, String NextPage, String NextPageLinkName)
		{
			FormSubmission form = new FormSubmission();
			form.CustomerName = CustomerName;
			form.ReferringUrl = ReferringUrl;
			form.FormName = FormName;
			form.PageName = PageName;
			form.FirstName = FirstName;
			form.LastName = LastName;
			form.EmailAddress = EmailAddress;
			form.NextPage = NextPage;
			form.NextPageLinkName = NextPageLinkName;
			form.Date = DateTime.Now;
			try
			{
				dc.FormSubmissions.InsertOnSubmit(form);
				dc.SubmitChanges();
			}
			catch (Exception e)
			{
			}
		}
	}
}