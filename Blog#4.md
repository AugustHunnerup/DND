![image](https://github.com/user-attachments/assets/c1a1495f-e4cf-4e09-8851-28652cfb8830)

In our project, the User Management section focuses on defining the types of users, implementing the login system, and ensuring proper handling of resources between different actors.

1)
We have an admin and all the users we want to create, in our case we created one user. We created a login razor that would allow a user to create a login that they would need in order to make a booking.

![Skærmbillede 2024-12-04 kl  15 00 45](https://github.com/user-attachments/assets/d93ea09e-ff7d-4b9a-878b-ecdd36af865f)


![Skærmbillede 2024-11-29 kl  10 51 56](https://github.com/user-attachments/assets/9da95c91-cc57-43bf-8771-ae727ed4fa02)


User must fill out two fields to enter their username and password. Using the @bind directive, these fields are bound to the properties userName and password. The userName and password variables in the component's C# code are automatically stored in the @bind directive, which ensures that the values entered by the user are kept in the userName and password variables.

![Skærmbillede 2024-11-29 kl  10 56 33](https://github.com/user-attachments/assets/d0c95d5e-7b99-41bd-94ea-61e33d72db59)


Making the authentication request using an IAuthService( assumed to be injected into the component) is handled by the LoginAsync method. The method first clears any already existing error messages by making errorLabel a blank string. Then, it uses the injected authService's LoginAsync method to attempt logging the user in with the userName and password that were provided. If the login is successful, the app uses the navMgr to navigate to the root of the app( "/"). NavigateTo( "/").
If an error occurs( for example, invalid login credentials), the exception is caught, logged to the console, and the errorLabel is updated with the error message that will appear on the UI.

These are the two policys we have made, where admin is securtiy level 2 and costumer is security level 1. This ensures the costumer would not have access to the whole page


2)
These are the two policys we have made, where admin is securtiy level 2 and costumer is security level 1. This ensures the costumer would not have access to the whole page.

![Skærmbillede 2024-12-04 kl  15 03 20](https://github.com/user-attachments/assets/af1ce6a3-4408-46b0-bdb3-2597e7f0754f)

We have used authorized in order to ensure the user must be logged to make a booking of hotel. Without a log in an error will be showed that would require them to log in.


