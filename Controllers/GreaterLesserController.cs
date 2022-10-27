// Jacob Dekok
// 10/25/2022
// Greater than or Less than Api
// Program will take two user inputs and check if they are numbers
// If they are then it will see which number is greater
// Peer Reviewed by: Arely Martinez -- Good Naming convention for both the route name and for the public strings etc. 
// when entering in some inputs in postman it respond with a vaild result. As for the code it looks very neat and its 
// easy to read. Just need to add a reponse at the end otherwise looks good. 


using Microsoft.AspNetCore.Mvc;

namespace dekokJGreaterLesserEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterLesserController : ControllerBase
{
    [HttpGet]
    [Route("GreaterLesser/{userNum1}/{userNum2}")]

    public string GreaterOrLess(string userNum1, string userNum2)
    {

        if(!int.TryParse(userNum1, out int num1)) return "Not Valid Number";
        if(!int.TryParse(userNum2, out int num2)) return "Not Valid Number";
        if (num1 > num2) return $"{num1} is greater than {num2}\n{num2} is less than {num1}";
        if (num1 < num2) return $"{num2} is greater than {num1}\n{num1} is less than {num2}";
        else return $"{num1} is equal to {num2}";
    }
}
