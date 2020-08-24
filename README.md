# 200824 .NET Views Classwork

### Set Up
- Create a new .NET MVC app called PetAdoption using the .NET CLI
- Run the application without debugging
- View the application in the browser
- Create a new postman collection for the application

### Assignment
- Create a `DogAdoption` controller that extends the base Controller class
- Dog Mock Data : create a list of 3 dogs using a Dog struct with properties `name`, `breed` and `age`

- Create a `CatAdoption` controller that extends the base Controller class
- Cat Mock Data : create a list of 3 cats using a Cat struct with properties `name`, `breed` and `age`

##### Dog Endpoint 1
- Method : get method that passes list of dogs to associated view
- View : display all properties of all dogs in dog list passed from method

##### Dog Endpoint 2
- Method : get method that finds a dog based on name query param and passes all properties of the found dog to the associated view depending on if a dog is found
- View for found dog : display all properties of the found dog from data passed from method
- View for no found dog : display the message : This pet is not in our records 

##### Dog Endpoint 3
- Method : post method that creates a dog from information passed in the body, adds the new dog to the dog list, and returns the appropriate view
- View : display all properties of all dogs in dog list passed from method

##### Cat Endpoint 1
- Method : get method that passes list of cats to associated view
- View : display all properties of all cats in cat list passed from method

##### Cat Endpoint 2
- Method : get method that finds a cat based on name query param and passes all properties of the found cat to the associated view depending on if a cat is found
- View for found cat : display all properties of the found cat from data passed from method
- View for no found cat : display the message : This pet is not in our records 

##### Cat Endpoint 3
- Method : post method that creates a cat from information passed in the body, adds the new cat to the cat list, and returns the appropriate view
- View : display all properties of all cats in cat list passed from method

### Additional Requirements
- Change the default .NET application landing page to be align with pet adoption
- Link to the views for all dogs and all cats from .NET application navigation bar
- Export the postman collection and include it in the repo 