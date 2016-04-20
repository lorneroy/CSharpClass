//This function validates the first and last name inputs on the form
function validateInputs()
{
    var firstName, lastName, response = "";

    var errorSet = false;

    firstName = document.getElementById("firstName").value;

    lastName = document.getElementById("lastName").value;
    
    if (firstName == null || firstName == "")
    {
        response += " Please fill out first name.";

        errorSet = true;
    }
    if (lastName == null || lastName == "")
    {
        response += " Please fill out last name";

        errorSet = true;
    }

    if (errorSet)
    {
        document.getElementById("nameValidationMessage").innerHTML = response.trim();

        return false;
    }
    else
    {
        return true;
    }
}