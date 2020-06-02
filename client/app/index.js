const express = require('express')
const app = express()
const clientPort = 3000
const apiPort = 5000
const fetch = require('node-fetch');

app.get('/', (request, response) => {
    var banjos = getBanjos().then(ret => response.send(ret));
})

// 1. todo
app.get('/filtered', (request, response) => {  
    // Implementieren Sie die Filtermethode:
    // Die Filtermethode soll das Herstellungsland als URL Parameter akzeptieren und die gefilterten Daten ausgeben.
})

app.get('/createNew', (request, response) => {

    var newBanjo = { 
        Name: request.query.name,
        Marke: request.query.marke,
        Herstellungsland: request.query.herstellungsland
    }

    putBanjo(newBanjo);
})

app.listen(clientPort, (err) => {
  if (err) {
    return console.log('something bad happened', err)
  }

  console.log(`server is listening on ${clientPort}`)
})

function getBanjos() {
  return new Promise((resolve, reject) => {
    fetch(`http://localhost:${apiPort}/banjos`,
      {
        method: "GET"
      })
      .then(result => resolve(result.json()))
      .catch(error => console.log(error));
  })
}

// 2. todo
// diese Methode soll das übergebene Banjo an den server schicken.
// an die Route /banjo als PUT methode und als JSON objekt
function putBanjo(newBanjo) {
    
}