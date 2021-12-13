let submitbtn = document.querySelector(".btn");
submitbtn.addEventListener("click", function (e) {
  let dayinput = document.querySelector("#day");
  console.log(dayinput.value); // dayinput value
  let monthinput = document.querySelector("#month");
  console.log(monthinput.value); // mothinput value
  let yearinput = document.querySelector("#year");
  console.log(yearinput.value); // yearinput value
  fetch(
    `https://api.aladhan.com/v1/calendar?latitude=40&longitude=49&method=2&month=${monthinput.value}&year=${yearinput.value}`
  )
    .then((res) => res.json())
    .then((res) => {
      let data = res.data;
    //   console.log(data);
      for (let i = 0; i < data.length; i++) {
          let currentday = data[dayinput.value-1];
          console.log(currentday.date.gregorian);
          console.log(currentday.date.gregorian.day) // Day
          console.log(currentday.date.gregorian.month.en); // Month
          console.log(currentday.date.gregorian.weekday.en) // Weekday
          console.log(currentday.timings.Asr) // Asr
          console.log(currentday.timings.Dhuhr) // Dhuhr
          console.log(currentday.timings.Fajr) // Fajr
          console.log(currentday.timings.Imsak) // Imsak
          console.log(currentday.timings.Isha) // Isha
          console.log(currentday.timings.Maghrib) // Maghrib
          console.log(currentday.timings.Midnight) // MIdnight
          console.log(currentday.timings.Sunrise) // Sunrise
          console.log(currentday.timings.Sunset) //Sunset
          let td1 = document.createElement("td")
          td1.innerHTML=currentday.date.gregorian.day;
          let td2 = document.createElement("td")
          td2.innerHTML = currentday.date.gregorian.weekday.en
          let td3 = document.createElement("td")
          td3.innerHTML = currentday.date.gregorian.month.en
          let td4 = document.createElement("td")
          td4.innerHTML = yearinput.value
          let td5 = document.createElement("td")
          td5.innerHTML = currentday.timings.Asr
          let td6 = document.createElement("td")
          td6.innerHTML = currentday.timings.Dhuhr
          let td7 = document.createElement("td")
          td7.innerHTML = currentday.timings.Fajr
          let td8 = document.createElement("td")
          td8.innerHTML = currentday.timings.Imsak
          let td9 = document.createElement("td")
          td9.innerHTML = currentday.timings.Isha
          let td10 = document.createElement("td")
          td10.innerHTML = currentday.timings.Maghrib
          let td11 = document.createElement("td")
          td11.innerHTML = currentday.timings.Midnight
          let td12 = document.createElement("td")
          td12.innerHTML = currentday.timings.Sunrise
          let td13 = document.createElement("td")
          td13.innerHTML = currentday.timings.Sunset
          let tr1 = document.createElement("tr")
          tr1.appendChild(td1)
          tr1.appendChild(td2)
          tr1.appendChild(td3)
          tr1.appendChild(td4)
          tr1.appendChild(td5)
          tr1.appendChild(td6)
          tr1.appendChild(td7)
          tr1.appendChild(td8)
          tr1.appendChild(td9)
          tr1.appendChild(td10)
          tr1.appendChild(td11)
          tr1.appendChild(td12)
          tr1.appendChild(td13)
          let tbody = document.querySelector(".tbody")
          tbody.appendChild(tr1);
          break;
      }
    });
});
