![image](https://github.com/user-attachments/assets/bdf2c7dd-1936-480f-a06b-acb3ad158937)

1)To meet the key requirements of our web application, loading images and displaying data from our backend service. One of the primary requirements was to ensure that images from events and hotels were correctly loaded and displayed on the frontend. To address this issue, we implemented a @configuration variable that contains the WEBAPIADDRESS – a setting that makes images fetched from the correct server address.

2) Our application consists of several key pages, each serving a specific function:

Home Page: Provides a general introduction and navigation to other pages, such as events and hotels.

Events Page: Displays an overview of upcoming and past events, with details and images for each event. Data for this page is fetched from our API and includes dynamic image loading.

Hotels Page: Offers users a list of available hotels in the area. Hotel images and information are also pulled from the API and displayed dynamically on the page.

Login Page: Allows users to log into the system. We have recently started implementing login functionality in Blazor, ensuring that only authorized users can access certain parts of the application.

3)

Noter: Vi har idag 9/11 været på skolen til at få hjælp med at loade vores billeder. Vi fik lavet en @configuration med WEBAPIADRESS da vores billeder fra events og hotel i vores program ikke blev vist da de blev kaldt på den forkerte host. Vi kiggede i developer tool på browseren under network og fandt frem til hvad vores fejl var. Vi fik sat billeder af vores hoteller og seværdigheder ind, og kan nu starte med at sætte login systemet ind i Blazor.
