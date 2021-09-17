const submit = document.querySelector('.submitbutton');

(function () {
	fetch("../Store/ListOfStores")
		.then(res => res.json())
		.then(data => {
			console.log(data)
			const los = document.querySelector('#stores');
			for (let x = 0; x < data.length; x++) {
				los.innerHTML += `<option value="${data[x].vLocation}">`;
			}
		})
})();

submit.addEventListener('click', (e) => {
	location.href = "../HTML/store.html";
});