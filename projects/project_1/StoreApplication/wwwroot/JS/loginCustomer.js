﻿//we can call an IIFE to get a list of all the customers
(function () {
	fetch("customer/ListOfCustomers")
		.then(res => res.json())
		.then(data => {
			console.log(data)
			const lop = document.querySelector('.listofcustomers');
			for (let x = 0; x < data.length; x++) {
				lop.innerHTML += `<p>The customer is ${data[x].FirstName} ${data[x].LastName}.</p>`;
			}
		});
})();