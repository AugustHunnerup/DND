![image](https://github.com/user-attachments/assets/c1a1495f-e4cf-4e09-8851-28652cfb8830)

In our project, the User Management section focuses on defining the types of users, implementing the login system, and ensuring proper handling of resources between different actors.

1)
We have an admin and all the users we want to create, in our case we created one user. We created a login razor that would allow a user to create a login that they would need in order to make a booking.
![Skærmbillede 2024-11-29 kl  10 51 56](https://github.com/user-attachments/assets/9da95c91-cc57-43bf-8771-ae727ed4fa02)


User must fill out two fields to enter their username and password. Using the @bind directive, these fields are bound to the properties userName and password. The userName and password variables in the component's C# code are automatically stored in the @bind directive, which ensures that the values entered by the user are kept in the userName and password variables.

![Skærmbillede 2024-11-29 kl  10 56 33](https://github.com/user-attachments/assets/d0c95d5e-7b99-41bd-94ea-61e33d72db59)


Making the authentication request using an IAuthService( assumed to be injected into the component) is handled by the LoginAsync method. The method first clears any already existing error messages by making errorLabel a blank string. Then, it uses the injected authService's LoginAsync method to attempt logging the user in with the userName and password that were provided. If the login is successful, the app uses the navMgr to navigate to the root of the app( "/"). NavigateTo( "/").
If an error occurs( for example, invalid login credentials), the exception is caught, logged to the console, and the errorLabel is updated with the error message that will appear on the UI.


2)

![Skærmbillede 2024-11-29 kl  11 11 09](https://github.com/user-attachments/assets/de32308e-cfe9-49c7-847a-39e3381dbdac)


The procedure begins when a user sends a server a login request. The controller method receives this request as a UserLoginDto object, which typically includes a username and password.

![Skærmbillede 2024-11-29 kl  11 12 56](https://github.com/user-attachments/assets/20a83e52-7681-454c-bd4e-8470ee27973e)


The server generates a JWT token once the user has been authenticated( credentials have been verified) to grant them permission to make future requests:

When a request is received with a valid JWT token, the server can extract the claims from the token and use them to determine whether to grant authorization. For instance, the server can check the user's role( ClaimTypes). Role) to make sure they have the necessary authorizations to access a particular resource.

