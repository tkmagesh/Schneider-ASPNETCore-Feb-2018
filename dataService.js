var http = require('http'),
	url = require('url')

//data from the server

var products = [
	{id : 6, name : 'Pen', cost : 50, units : 20, category : 'stationary'},
	{id : 9, name : 'Ten', cost : 70, units : 70, category : 'stationary'},
	{id : 3, name : 'Len', cost : 60, units : 60, category : 'grocery'},
	{id : 5, name : 'Zen', cost : 30, units : 30, category : 'grocery'},
	{id : 1, name : 'Ken', cost : 20, units : 80, category : 'utencil'},
];

http.createServer((req, res) => {

	if (url.parse(req.url).pathname === '/products'){
		res.end(JSON.stringify({ products : products}));
	} else {
		res.end('A dummy service');
	}
}).listen(8000);