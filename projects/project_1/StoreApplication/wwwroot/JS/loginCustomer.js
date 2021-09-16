const listofcustomers = document.querySelector('#listofcustomers');
const submit = document.querySelector('.submitbutton');

(function () {
	fetch("../Customer/ListOfCustomers")
		.then(res => res.json())
		.then(data => {
			console.log(data)
			const loc = document.querySelector('#customers');
			for (let x = 0; x < data.length; x++) {
				loc.innerHTML += `<option value="${data[x].vFirstName} ${data[x].vLastName}">`;
			}
		})
})();

submit.addEventListener('click', (e) => {
	const Value = document.querySelector('#listofcustomers').value;

	if (Value == " ") {
		alert("It seems you don't have an account. Please register. \nYou will be redirected.");
		location.href = "../HTML/registerCustomer.html";
	}
	else {
		location.href = "../HTML/customer.html";
	}
});