(function () {
	fetch("../Book/ListOfBooks")
		.then(res => res.text())          // convert to plain text
		.then(text => console.log(text))
		//.then(res => res.json())
		//.then(data => {
		//	console.log(data)
		//	const lob = document.querySelector('#booklist');
		//	for (let x = 0; x < data.length; x++) {
		//		lob.innerHTML += `<p>"${data[x].vBookTypeId} ${data[x].vBookGenreId} ${data[x].vBookPrice} ${data[x].vQuantityAvailable}">`;
		//	}
		//})
})();

function LogOut() {
	location.href = "../index.html";
}