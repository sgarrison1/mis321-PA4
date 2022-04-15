const baseUrl = "https://localhost:8001/api/songs"
var songList = [];
var mySong = {};

function loadSongs() { 
    fetch(baseUrl).then(function (response) {
                console.log(response);
                return response.json();
            }).then(function (json) {
                document.getElementById("cards").innerHTML = "";
        console.log("hi")
        var songs = json;
        for(let i = 0; i < songs.length; i++) {
            console.log("hello")
            const card = document.createElement('div');
            card.className = "card col-md-4 bg-dark text-white";
            card.innerHTML = `
                    <img src="./resources/music.jpeg" class="card-img" alt="..."/>
                    <div class="card-img-overlay">
                    <h5 class="card-title">${songs[i].songTitle}  ID:${songs[i].songID} favorite: ${songs[i].favorited} </h5>
                    </div> 
                    `
            document.getElementById("cards").appendChild(card);
        }
           }).catch(function (error) {
                    console.log(error);
                })
}

addSongs = () => { //get is handle on load , delete , put(favorits)
    let searchString = document.getElementById("addtitle").value;
    const putSongApiUrl = baseUrl;
    fetch(putSongApiUrl, {
        method: "POST", //this equals the name of the method in the controller
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            songTitle: searchString,
            songTimestamp: new Date().toISOString(),
            deleted: "n",
            favorited: "n"
        })
    })
        .then((res) => res.text())
        .then((json) => {
            console.log(json)
            let html = ``;

            console.log(song.title)
            const card = document.createElement('div');
            card.className = "card col-md-4 bg-dark text-white";
            card.innerHTML = `
            <img src="./resources/music.jpeg" class="card-img" alt="..."/>
            <div class="card-img-overlay">
            <h5 class="card-title">${searchString}</h5>
            </div>
            `

            document.getElementById("cards").appendChild(card);


        }).catch(function (error) {
            console.log(error);
        }).finally(() => {
           loadSongs();
        })
}


function deleteSongs() {

    let searchString = document.getElementById("deleteid").value;
    console.log(searchString);
    const deleteSongUrl = baseUrl;
    console.log(deleteSongUrl);

    fetch(deleteSongUrl, {
        method: "DELETE",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            songID: searchString,
            songTimestamp: new Date().toISOString(),
            deleted: "y",
            favorited: "n"
        })
    })
    .then((response) => {
        console.log(response);
        loadSongs();
    });
}

function favoriteSongs(){
    let searchString = document.getElementById("favoriteid").value;
    console.log(searchString);
    const updateSongUrl = baseUrl;
    console.log(updateSongUrl);

    fetch(updateSongUrl, {
        method: "PUT",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            songID: searchString,
            songTimestamp: new Date().toISOString(),
            deleted: "n",
            favorited: "y"
        })
    })
    .then((response) => {
        console.log(response);
        loadSongs();
    });

}

// function findSongs() {
//     var url = "https://www.songsterr.com/a/ra/songs.json?pattern="
//     let searchString = document.getElementById("searchSong").value;

//     url += searchString;

//     console.log(searchString)

//     fetch(Url).then(function (response) {
//         console.log(response);
//         return response.json();
//     }).then(function (json) {
//         console.log(json)
//         let html = ``;

//         json.forEach((song) => {
//             console.log(song.title)
//             html += `<div class="card col-md-4 bg-dark text-white">`;
//             html += `<img src="./resources/music.jpeg" class="card-img" alt="...">`;
//             html += `<div class="card-img-overlay">`;
//             html += `<h5 class="card-title">` + song.title + `</h5>`;
//             html += `</div>`;
//             html += `</div>`;
//         });

//         if (html === ``) {
//             html = "No Songs found :("
//         }
//         document.getElementById("searchSongs").innerHTML = html;

//     }).catch(function (error) {
//         console.log(error);
//     })
// }

