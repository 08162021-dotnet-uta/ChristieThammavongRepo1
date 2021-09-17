/*const newcustomer = document.querySelector("#newcustomer");*/
//const submitcustomer = document.querySelector(".submitbutton");

//submitcustomer.addEventListener('submit', (e) => {
//	e.preventDefault();
//	const firstname = newcustomer.FirstName.value;
//	const lastname = newcustomer.LastName.value;
//	const userData = { VCustomerId: -1, VFirstName: firstname, VLastName: lastname }

//	//GET fetch request
//	fetch('../Customer/RegisterCustomer', {
//		method: 'POST',
//		headers: {
//			'Accept': 'application/json',
//			'Content-Type': 'application/json'
//		},
//		body: JSON.stringify(userData)
//	})
//		.then(response => {
//			if (!response.ok) {
//				throw new Error(`Network response was not ok (${response.status})`);
//			}
//			else       // When the page is loaded convert it to text
//				return response.json();
//		})
//		.then((jsonResponse) => {
//			//debugger;
//			console.log(jsonResponse);
//			//registerResponse.textContent = ` Welcome, ${jsonResponse.fname} ${jsonResponse.lname}`;
//			//console.log(jsonResponse);
//			//return jsonResponse;
//		})
//		//.then(res => {
//		//	//save the personId to localStorage
//		//	localStorage.setItem('person', JSON.stringify(res));// this is available to the whole browser
//		//	//sessionStorage.setItem('personId', res);// this is ony vailable to the certain window tab.
//		//	//switch the screen
//		//	// location = 'personmenu.html';// 
//		//})
//		.catch(function (err) {
//			console.log('Failed to fetch page: ', err);
//		});
//});