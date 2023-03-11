/* ALGORITHM PosBinaryToDecimal(A[0..n - 1])
    // Input: Array A[0..n - 1] of positive binary number
    // Output: Positive decimal representation of binary number
        reverse A
        dec <- 0
        for i <- 0 to n - 1 do
            A[i] <- 2^i * A[i]
            dec <- dec + A[i]
        return dec

*/

uint PosBinaryToDecimal(byte[] bits)
{
    uint dec = 0;

    Array.Reverse(bits);
    
    for (int i = 0; i < bits.Length; i++)
    {
        bits[i] = (byte)(Math.Pow(2, i) * bits[i]);
        dec = dec + bits[i];
    }

    return dec;
}

byte[] binary = new byte[] { 1, 0, 1, 1 }; // should = 11
Console.Write(PosBinaryToDecimal(binary));