using FirebaseAdmin;
using Microsoft.AspNetCore.Mvc;
using Google.Cloud.Firestore;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace FireBaseNetCore.Controllers
{
    [Route("api/[controller]")]
    public class FirebaseController: ControllerBase
    {
        public FirebaseController()
        {
        }

        [HttpGet]
        [Route("testfirebase")]
        public IActionResult TestFirebaseConnection()
        {
            if (FirebaseApp.DefaultInstance == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Firebase connection not initialized");
            }
            else
            {
                return Ok("Firebase connection successful!");
            }
        }

    }
}
