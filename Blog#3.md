![image](https://github.com/user-attachments/assets/bdf2c7dd-1936-480f-a06b-acb3ad158937)

1)
User Stories: As a user, I want to be able to book a hotel from the system so that I can see the best option for both price and traveling length.
![image](https://github.com/user-attachments/assets/cd71cfef-22b7-4257-8771-0cc361fe5ef5)
![image](https://github.com/user-attachments/assets/c0557887-d516-4926-8642-fba3c577028d)

As a user, I want to be able to Login to the booking system with my credentials so that I can access my saved trips, and manage my bookings while also being able to change my password.
![image](https://github.com/user-attachments/assets/29ccc832-da46-4891-817e-a6cd7892367d)
![image](https://github.com/user-attachments/assets/b49baf01-7d97-45b5-8f4b-24679027937d)
![image](https://github.com/user-attachments/assets/b895617c-974c-41fa-aeb8-a406bad098e9)
![image](https://github.com/user-attachments/assets/384df4a6-0d17-41e6-9c83-4d03175b462d)

As a user, I want to be able to view my current and previous bookings so that I can easily track my travel plans.
![image](https://github.com/user-attachments/assets/0e922a19-5eda-4710-8fe8-5364f5f5353a)

As a user, I want to be able to cancel or modify my bookings, so that I can change my hotel booking.
![image](https://github.com/user-attachments/assets/b40fb811-951b-4756-b8b0-54030fcae4d9)
2) Our application consists of several key pages, each serving a specific function:

Home Page: Provides a general introduction and navigation to other pages, such as events and hotels.

Events Page: Displays an overview of upcoming and past events, with details and images for each event. Data for this page is fetched from our API and includes dynamic image loading.

Hotels Page: Offers users a list of available hotels in the area. Hotel images and information are also pulled from the API and displayed dynamically on the page.

Login Page: Allows users to log into the system. We have recently started implementing login functionality in Blazor, ensuring that only authorized users can access certain parts of the application.

3)
In our hotel booking project, the frontend connects to the web system by making HTTP requests to the backend, which processes the data and sends back responses. The frontend interacts with the backend using APIs. These APIs help to manage user actions like booking hotels, logging in, viewing and canceling bookings, and getting personalized recommendations.






Notes from Today: 8/11-24
Today, we were at school to get assistance with loading images correctly in our web application. We identified that the images were not displaying because they were being called from an incorrect host. By using the Developer Tools in the browser, we found the error and were able to correct the WEBAPIADDRESS in our configuration. This allowed us to display images of both hotels and attractions, significantly improving the user experience.

The next step will be to implement the login system in Blazor, so users can log in and access protected areas of the application. This will add an additional level of functionality and security to the application.
