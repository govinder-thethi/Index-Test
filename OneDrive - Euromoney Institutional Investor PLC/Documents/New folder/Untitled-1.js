const http = new XMLHttpRequest();
const url = 'static/news.json';
http.open("GET", url);
http.send();

http.onreadystatechange=(e)=>{
    console.log(http.responseText)
}