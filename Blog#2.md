![image](https://github.com/user-attachments/assets/97e97808-b787-4722-8062-27c1e3dcd1e2) 

        // POST: api/HotelControllers
        [HttpPost]
        public ActionResult<Hotel> CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetHotel), new { id = hotel.Id }, hotel);
        }

        // PUT: api/HotelControllers/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateHotel(int id, Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return BadRequest();
            }

            _context.Entry(hotel).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/HotelControllers/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteHotel(int id)
        {
            var hotel = _context.Hotels.Find(id);
            if (hotel == null)
            {
                return NotFound();
            }

            _context.Hotels.Remove(hotel);
            _context.SaveChanges();

            return NoContent();
        }
    }
}

HTTP Verbs:
GET: Retrieves resources.
POST: Creates new resources.
PUT: Updates existing resources.
DELETE: Removes resources.



1) We learned to make getignore and to connect our servers together by livesharing, restoring and could work on the same project. 

2) We took notes on authentacation, and how that worked.

3) Renaming our files, that were complicated.

   
Reflection from today 01-11-2024:
We have set up github desktop on each of our computers. We then downloaded the project and found out about fetching and pulling in order to save changes. This enables us to make changes when we aren't working together face to face. This also gives us freedom to work alone and then discuss the changes when we meet again. 
In addition, we wanted to change the name of the project which was Pizza2. The easiest way for us to do it was to make a new folder with the name HotelWEBAPP. We copied everything from the last folder into the new one. This gave us a few problems since not every person could see the new folder. 
We also made a Getignore in order to download the newest version of the project without the settings from the individual's computer. This means, that the code won't be machine code, but it will be translated to C#. 
We also had a problem where couldn't put our API key in our API folder in the Github.

