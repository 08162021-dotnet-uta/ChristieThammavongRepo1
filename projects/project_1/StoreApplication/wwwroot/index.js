const listofcustomers = document.querySelector('.listofcustomers');
const seecustomers = document.querySelector('.seecustomers');

seecustomers.addEventListener('click', (e) => {
	fetch('customer/ListOfCustomers')
		.then(res => res.json())
		.then(data => {
			console.log(data)
			const lop = document.querySelector('.listofcustomers');
			for (let x = 0; x < data.length; x++) {
				lop.innerHTML += `<p>The customer is ${data[x].fname} ${data[x].lname}.</p>`;
			}
	});
});

function SeeCustomers() {
    location.href = "customer.html";
}