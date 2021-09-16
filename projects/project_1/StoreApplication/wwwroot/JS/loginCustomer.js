const listofcustomers = document.querySelector('#listofcustomers');

(function () {
	fetch("../Customer/ListOfCustomers")
		.then(res => res.json())
		.then(data => {
			console.log(data)
			const loc = document.querySelector('#customers');
			for (let x = 0; x < data.length; x++) {
				/*lop.innerHTML += `<p>The customer is ${data[x].fname} ${data[x].lname}.</p>`;*/
				loc.innerHTML += `<option value="${data[x].vFirstName} ${data[x].vLastName}">`;
			}
		})
}) ();

//listofcustomers.addEventListener('keyup', (e) => {
//	fetch('../Customer/ListOfCustomers') // Fetch() is default 'GET'
//		.then(res => {
//			if (!res.ok) {
//				console.log('NOT OK')
//				throw new Error(`Network response was not ok (${res.status})`);
//			}
//			else {
//				return res.json();
//			}
//		})
//		.then(res => {
//			console.log(res)
//			const loc = document.querySelector('#customers');
//			for (let x = 0; x < res.length; x++) {
//				/*loc.innerHTML += `<p>The customer is ${res[x].vFirstName} ${res[x].vLastName}.</p>`;*/
//				loc.innerHTML += `<option value="${res[x].vFirstName} ${res[x].vLastName}">`;
//			}
//		})
//		.catch(err => console.log(`There was an error ${err}`));
//});
