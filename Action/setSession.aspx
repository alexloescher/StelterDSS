<%@ Page Language="C#" %>
<%
    // Expected input: categoryType, categoryValue

    // Function: sets the donor category value for the given category type overriding any previous value

    string catType = Request["key"];
    string catValue = Request["value"];

    // Check for a valid category type (key) and then add its value to the donor profile
    if (catType != null && catType.Length > 0)
    {
        Dictionary<string, string> donorCats = Session["donorCats"] as Dictionary<string, string>;
        if (donorCats != null)
        {
            donorCats.Remove(catType);
            donorCats.Add(catType, catValue);
        }
        else
        {
            donorCats = new Dictionary<string, string>();
            donorCats.Add(catType, catValue);
        }

        Session["donorCats"] = donorCats;
    }
%>