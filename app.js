const http = require('http'); 
console.log("Kubia server starting... ") ; 
var handler = function(request, response) {
	console.log("Received request from " + request.connection.remoteAddress); 
	response.writeHead(200); 
	response.end("hello");
}
var www = http.createServer(handler); 
www.listen(8080);