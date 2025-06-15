public class Logger {
    private static Logger instance = null;
    private Logger(){
        System.out.println("Logger Constructor Called");
    }
    public static Logger getInstance(){
        if(instance == null){
            instance = new Logger();
        }
        return instance;
    }
    public void log(String message){
        System.out.println("Log: "+message);
    }

}
