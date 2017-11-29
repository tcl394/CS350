var model = require('../mongo/user_model.js');

class user{

    constructor(first_name, last_name, password, email) {
      // always initialize all instance properties
      this.id = "";
      this.first_name = first_name;
      this.last_name = last_name;
      this.password = password;
      this.email = email;
      }
    // class methods
    get_first_name(){
        return this.first_name;
    }
    get_last_name(){
        return this.last_name;
    }
    get_email(){
        return this.email;
    }
    get_id(){
        return this.id;
    }
    set_id(_id){
        this.id = _id;
    }

}
 module.exports = user;
