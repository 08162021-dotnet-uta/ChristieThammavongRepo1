const seecustomers = document.querySelector('.seecustomers');

seecustomers.addEventListener('click', (e) => {
	fetch('Customer/ListOfCustomers') // Fetch() is default 'GET'
		.then(res => {
			if (!res.ok) {
				console.log('NOT OK')
				throw new Error(`Network response was not ok (${res.status})`);
			}
			else {
				return res.json();
			}
		})
		.then(res => {
			console.log(res)
			const loc = document.querySelector('.listofcustomers');
			for (let x = 0; x < res.length; x++) {
				loc.innerHTML += `<p>The customer is ${res[x].vFirstName} ${res[x].vLastName}.</p>`;
			}
		})
		.catch(err => console.log(`There was an error ${err}`));
});

function SeeCustomers() {
    location.href = "customer.html";
}