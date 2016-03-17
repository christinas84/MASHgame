function random_number(num) {      
    var num = num || 4  
    return Math.floor(Math.random() * num); 
}

function mash_choice() {  
    var mash = ['mansion', 'apartment', 'shack', 'house'];   
    var randomNum = random_number(4);  
    return mash[randomNum];   
}

function get_answer(category) {
    // Get a random answer from the available answers
    var choices = [];    
    var selector = 'input[name="' + category + '[]"]';   
    var inputs = document.querySelectorAll(selector);  
    var answer;

    for (var i = 0; i < inputs.length; i++) {  
        answer = inputs[i].value;   
        if (answer !== '') {   
            choices.push(answer); 
        }
    }
    return choices[random_number(choices.length)];    
}

function fill_in_answers(answers) {
    var home = document.querySelector('#home');  
    var profession = document.querySelector('#profession');
    var pet = document.querySelector('#pet');
    var location = document.querySelector('#location');
    var kid = document.querySelector('#kid');
    var car = document.querySelector('#car');
    var marry = document.querySelector('#marry');

    // Fill them with the provided answers
    home.innerText = answers['mash'];
    profession.innerText = answers['profession'];
    pet.innerText = answers['pet'];
    location.innerText = answers['location'];
    kid.innerText = answers['kid'];
    car.innerText = answers['car'];
    marry.innerText = answers['marry'];

    home.innerHTML = answers.mash;  
    profession.innerHTML = answers.profession;  
    pet.innerHTML = answers.pet;
    location.innerHTML = answers.location;
    kid.innerHTMl = answers.location;
    car.innerHTML = answers.car;
    marry.innerHTML = answers.marry; 
}

function handle_submission(evt) {
    evt.preventDefault();   
    evt.stopPropagation();  // Stop the form from reloading the page

   
    var answers = {
        'mash': mash_choice(),
        'profession': get_answer('profession'),
        'pet': get_answer('pet'),
        'location': get_answer('location'),
        'kid': get_answer('kid'),
        'car': get_answer('car'),
        'marry' : get_answer('marry')
    }
  
    fill_in_answers(answers);

    var answer_div = document.querySelector('#answers');
    answer_div.classList.add('show');
}


var form = document.querySelector('#mash');
form.addEventListener('submit', handle_submission);





