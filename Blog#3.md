![image](https://github.com/user-attachments/assets/bdf2c7dd-1936-480f-a06b-acb3ad158937)

1)To meet the key requirements of our web application, loading images and displaying data from our backend service. One of the primary requirements was to ensure that images from events and hotels were correctly loaded and displayed on the frontend. To address this issue, we implemented a @configuration variable that contains the WEBAPIADDRESS – a setting that makes images fetched from the correct server address.
We had a couple key requirments. We wanted the user to be able to book a hotel for there stay. Therefore we created a HotelBooking.razor 

 ![image](https://github.com/user-attachments/assets/8c888747-d737-4b96-a7e9-10cfec8aeb07)

    Here you can see we added a check in, check out date and number of people staying.
    
    We also wanted to add a login for the user:  
   ![image](https://github.com/user-attachments/assets/18cb391c-7728-4d8c-b400-d636a02295bb)

    Here you can see we added a login field where the user can add a username and a password

2) Our application consists of several key pages, each serving a specific function:

Home Page: Provides a general introduction and navigation to other pages, such as events and hotels.

Events Page: Displays an overview of upcoming and past events, with details and images for each event. Data for this page is fetched from our API and includes dynamic image loading.

Hotels Page: Offers users a list of available hotels in the area. Hotel images and information are also pulled from the API and displayed dynamically on the page.

Login Page: Allows users to log into the system. We have recently started implementing login functionality in Blazor, ensuring that only authorized users can access certain parts of the application.

3)

Notes from Today: 8/11-24
Today, we were at school to get assistance with loading images correctly in our web application. We identified that the images were not displaying because they were being called from an incorrect host. By using the Developer Tools in the browser, we found the error and were able to correct the WEBAPIADDRESS in our configuration. This allowed us to display images of both hotels and attractions, significantly improving the user experience.

The next step will be to implement the login system in Blazor, so users can log in and access protected areas of the application. This will add an additional level of functionality and security to the application.
