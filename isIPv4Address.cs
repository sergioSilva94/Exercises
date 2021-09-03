/*An IP address is a numerical label assigned to each device (e.g., computer, printer) 
participating in a computer network that uses the Internet Protocol for communication. 
There are two versions of the Internet protocol, and thus two versions of addresses. One of them is the IPv4 address.

Given a string, find out if it satisfies the IPv4 address naming rules.*/

bool isIPv4Address(string inputString) {
    string[] segmentosIp = inputString.Split('.');
    if(segmentosIp.Length != 4) return false;
    
    foreach(string s in segmentosIp)
    {
        if(String.IsNullOrEmpty(s))return false;
        if(!s.All(char.IsDigit) || s.Length > 3)return false;
        if(s.Length > 1)
        {
            if(s[0] == '0') return false;
        }
        int num = Convert.ToInt16(s);
        if(num > 255 || num  < 0) return false;
    }
    return true;
}