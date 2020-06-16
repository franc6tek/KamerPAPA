export class Auth{
    constructor(public Id: number, public Email: string, public MotDePasse: string, public DateCreation: Date, 
        public NomUtilisateur: string, public IsAdmin: boolean){}
}