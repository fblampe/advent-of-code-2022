class Day3
{
    private static List<string> rucksacks = input.Split("\n").ToList();

    public static void Main(string[] args)
    {
        PartTwo();
    }

    private static void PartTwo()
    {
         List<string[]> groupRucksacks = rucksacks.Chunk(3).ToList();
         Console.WriteLine(groupRucksacks.Select(groupRucksack =>
         {
             HashSet<char> duplicateItemTypes = new HashSet<char>();
             duplicateItemTypes.UnionWith(groupRucksack[0]);
             duplicateItemTypes.IntersectWith(groupRucksack[1]);
             duplicateItemTypes.IntersectWith(groupRucksack[2]);
             return GetPriority(duplicateItemTypes);
         }).Sum());
    }
    
    private static void PartOne()
    {
        Console.WriteLine(rucksacks.Select(rucksack =>
        {
            string compartment1 = rucksack[..(rucksack.Length / 2)];
            string compartment2 = rucksack[(rucksack.Length / 2)..];

            HashSet<char> duplicateItemTypes = new HashSet<char>();
            duplicateItemTypes.UnionWith(compartment1);
            duplicateItemTypes.IntersectWith(compartment2);

            return GetPriority(duplicateItemTypes);
        }).Sum());
    }

    private static double GetPriority(HashSet<char> duplicateItemTypes)
    {
        HashSet<char>.Enumerator enumerator = duplicateItemTypes.GetEnumerator();
        enumerator.MoveNext();
        char item = enumerator.Current;
        enumerator.Dispose();
        return char.IsLower(item) ? item - 96 : item - 64 + 26;
    }

    const string input = @"jVTBgVbgJQVrTLRRsLvRzWcZvnDs
dhtmhfdfNlNNldfqmPCflqGbNZDHsDWcRzvczWsczZNzHz
tmwwwCCfbJSMbwMb
hsrZZhHlhrHmPPbMbDFDQdnQgLfMFDdDQQ
GpBtwtqrcCcjgnLgqfgDDgRn
cJwVwpCpGJctJtBcCrSCGrVJhlsbvSvTvbmHmmsWmHslmsHm
gCtWJvmfmGGwVVMhJw
nzRSpZbSVFFRDFSDzcplddqplqMhQMclMp
zFLszzRTDnZnbTZTRZsVNgCjrvfvgtvNmtfvLW
glRQRpQQtQtGtQws
TnmbLqvBFRFFLPBFnPbvRBhshTtHWhwzdwtHdsdzWhws
qmCLPNmCFnLBnmPPqVbFLRrJjVggDgJjlZVVDjDlDD
vRRgpWvPQFdTFDDNQs
bqtCmltmlbwqLVLZqwtmLBBTMcGBddTTBgFNGcZGMD
bbtmJmjlVlwblwwbwzbbvrrznvzShgRhRvhfWrWn
ZMhThfNcpbbMNNjsHpmpsRqsPmRs
wQjDgggQDPqqDlsD
SCwSzvLVCSVtQVgLnrccfdGdTdZfcZMtjJhG
wNnNmNHnNPPwwPGCrLSZZvdVVZvBtMMvdm
WQzlhzjzbBtMMlBrMl
szbgWhJjTTcsWTqgzsqcsGHfwNcwfwnHHrCGCPPGwr
CNsbpFCMSrmDhQHNNGmH
fQPPPcqvljQzjVDDgRBhGGqDgqqD
ZctlcVzcfltQtnrndbQMCM
NQjQjQvZvZjcvrrrNjgTQgBQwTJsJswJlbGstqqtmGhmwhqw
PWpHRzRnPHHSCnPFwlqhbtqGZClJqGqG
ZzVpMpWPHnVzzpWzDRzSZrcdDQdrQNrcQgQfjcNfjf
BSZMtdtZBzMFvhCbBJDbhDDC
qcqVVmccrmVcjrlHqTrjDJRPQhWvPWWfPvblffDf
cHTrbGwpmGwVjdFMnzpLznMztd
DGDGGbNgTgJQQLMRMMTNVzvPsPbdsfPVsdVVZfPf
lcCmmlpwwnwSjCHtFpCpHzCrZsVrBZZzdvDfVrsfZd
lSHwnjpFmppHqppttttcFmnhMLGNRLhTMDqJLQNLLQNLhJ
WqWfDWBjBjLbfcbbqGbWqQsrFFztsppMFCzgCJzJCrFpCM
VRlhdHZTZVRRmZwlmFrJwFpMMDDrrrtJwg
PPVddvvDZmRmHvndTHmLcbcjSjLQBGWGGQWSqP
HHvgvwHMPMwHwmcRfJNFchFGNNCm
BsTDsjzBCCBJGffN
jznSnSdqzqnQTbdDljQjQSMHWWvvgWvtZlrWpPfWwtPr
DJCJJCNjCDRfDfDRhDnNhfjFPgbGbddBTjFdTFTPbgGSdF
cmMcMVqBZVcwsGFgGqgWdFqb
vcZVzwmHVcrtrwMMvvmBHwNNCDpQRfhLhrNJNfJDDDRC
VWSSScsncpDRdnsWsVncVzTwMMMHtMTrLTLMMVHM
fjJvQqBCQNhfQlZZnqmFHLFMTFTzwzLzrHMB
CqfjjQZJPjjvpRppDPgbnSnP
tLnjNwjRWttdCwRLsfGzfzPbzbWbQQPT
cvvBvlBrFrlTffsbfTqZ
vmrFpsrvFMMMNwhtDwhN
wzgRNqwtgzMWtqGwCssBBSBZnSRsrQQS
bbjLTmpjpHcpVncVdmffPCDrjZDSDsZffDQC
pbVFncvvbpbbHJJHVdvqMGMJNwWlNlJMwqzlNM
TdszlzFsRQqFdRzqwwQGlFsGmmSBBdmdVVmgSZdSPZBBBmSD
HMCCMbJHJJLHSmSvZLBcSDBP
NWbhPjfrbbNfWCPjhNnGsNzsqpQszTQGRwGQzR
ppQpTNCPBTlNBVmNQTNrrrrtqsrWbGrVFWqhZb
DMvDHnjRvMDLghhhgbqZWbqFSS
vWvMRRJDLMnHLJjDwWnnndcllNTzBmClQBpBBzQQzCBzCJ
VsNZfPMnrCnlCnWtbvBbvwtTbZwT
JhJQdQhmRHDRdLmHJhljhphgGwtttmcvbwwTWtvtbGBttc
jqLpjSLDHlhnffCMzsqCPP
JzJdLRmmzJwrLLwLJwLTWwBrMrpHlFnScVVqccrBHSlc
tvQDQhjhvbqFqFSpjHSV
QbgZtsgfbNNQbgbsbQRfmWRJwJGWWTPRwqzR
MwvDgpwszSpSJPsssMccTQfTDfTQRTljfRfT
PmGbWhbVtZWPTqRrcTrrjTrt
NbZbWHBmVGmLbZVBVNLPsMBzwSSzMJMCsCzvnvSp
cTpgTnpzbZlJHTZm
jRrLVtqtvtrjqsHZhvpmBfJHmhhp
FqDsFLCwCVRDqwgNQcQMwnncnMpg
sCCtssdZdZJmMbNJDmtmJzLSrcGfHGLTHDHnGLrHTSSn
gQwRRWqwqgpggFWPjPpFnSTSnHNfLLQrccrLGHLL
qqlpqhjFwPgPwvvRgFlPdslZCzMZtVdtVdVMtJlN
BWVmPtRVRRWDNtZBVQzCfdscmfjcfdfzzSfz
MhgJLbGggHbqpGgpgJbrFJdjwsCChCzllzCdjDSszCCD
grpDLFrbgpJnqJrHGFHGqMHBBPRWQTPWZBQVTQWnPNVvBt
gJfggdmHDgfJJWzCcbqvcqcmTG
hLZlRBZNlBlrpprzrWqvtHvvGtbvHT
sNLRjHZLNVnZZVLppnhNsMFJSjFPPQMjwgMPPfDMfS
mDDzHfrPBvJRJhpBRg
SsTSTwJwcbCtwssGFVWppgZRbLpLRNhpLhbLvg
ttVCGjTGrfJJMfjD
ffhcsTjnfqHLqvZSHvHB
CsgmPVmstsQVpRbHBvFbHBDMvZLZGB
ppgpmmRVpVPwPrrrTNlcrwrlWs
NDtssPNBjQtCtCcT
ZZqncfqhZqhJZFTJTllCGVljSl
ndrWbfZwWhngwbqbZnMZcwWhDmmLDmzvHPvzNLdmzsvBBHHP
FQtptwMppSFQRRQfSfvTrTJJJTrvLjMMJbgJ
CcDqWBWzbldcchDGCWBCBhdGrvhnrsrjjsJvLvghrjjnnjsJ
GDBldPDGqPGWVBBcwHFmSmbpSpNRwHFV
CwHwCFwtCmdCDflHDpwFnnvzhhNJhJNzmhzhhNMM
sTbZssPqScTrqSWSShdMvgMRRzdRRQ
brBrsWPTrdrWsPcBcTcGqDLDDHjFfDClwLLBfFlFlw
lNptNFWpbVMjlBgQgvdNBRQLrd
TsDCDfSCQqqQQqDq
TwTmwPPPzZSCccScJwpWZHljtbWMFFQVHpnj
fhFmwbrgnCcSnwtS
vZVVZvQZVPZsMnNSccMHPN
ddzvQJvQzBzWRTJzdRVSWGqbRbgmfbFFbmbgmpmlff
wdslVdQtdlBVHDrHBcBc
TJWvpncCcJzCWcRfWvJRRpfZHBDZZHmDZPBjZHjZrSfb
TRJFvvWpTRRWCpCgGtgtGQdlcNtsGlwg
rCHvRLJtCjpbRCLpptHMVCQgGlMndVlQGNcCMc
zZfzSmsfSsMzMccQMVcN
ssSmPmSmhwVhZBZsTBRJrtRjtbDvjvrTHLtJ
wswRCNHHhsrWFsGfGWFBGb
lLtngDPLgLJPttgWzQWlbCfBlmBFCW
DcDnVpcnnJPngjjcdpRhwNZSCZNdNdvr
NWNzWpfMRHfwsRNznPdjtdjJtPVPHVdJ
CSLTZBrGbSmClvBVdGzFVVcFdjjjnV
SrZhZbTvmmbbLvwQzMhsfhqqWwQR
vvZqwFBZvzZzrqltPsQstrGGpMcbbR
bhJdjJJmTRQMTMMPPM
mCmgLbdVVVLhVnJmLgJhBWZFDlqFvwZDlZBnBvWB
sMrcmQcHHsLLrSHZhvdCddvtJJFl
jzjjWplWpPRPDzPzfRGjqvdJqqqCtqdqDvdDqtwC
pPNWVpGGVVffPlnSMnMsTmgsQVLr
zGMMRbpGmqqqNRmmzbNfbzPRPlvThCTrHPnrHSVPlTHR
LSjjwgsjtTjhPhHhvC
dJZtJwFgtBLDZZbmNMGzMMqS
ZrnstppPWccnsFWpnZnRdjRtjbCtSSRjjjLLbG
JgBQPJvPgHHJvmmzwGGLdjHGSjShGHqdHL
wTJvPzmTJvzJQBfwNmTmlPsrVfnVFpcMVZprDpFrsrVc
ssGCtltsSdJJtQjPdvHvfbfvqLHqZtBfVb
pzRwwDwDTgzbqVTVvHqVWB
grzHnRpmFpDMnmzFhplJCjlsPdGJSjsFCdFs
CTGBBGCBlSTTSsnTMrQbNrBMtpVzNddWHWzVpHVtdHmwhphm
JqPZgMRFFvFZvDZMDFcFFfDchdtdPWpzpWhtHWwwhVzWpddW
ZfLZMcgqRDjgjcLccDRDLsbbrSBBlQGQBCTrCBnT
VjVGVqSqFLFVSqCjFJSsbfPprHbCCRRPccRWPW
wwnQmtwlvNmpZRsPsWWNbZ
DBhhhznhddldnvjMqJMTqDMGPSjF
TTJbsJPPBDsBVbJJGJBGWLfmWzgmDmzmLqmmLddQ
jHwVZZjwFZlzLzWZLMdLqM
HHHhjHplrHSpcCSvjlsNPbNRbRnVTrRsNNNJ
NzMMLZtwRmbwFnVDhnqD
SlsJsSdSJdNJnFphVHFjph
vlrsTlGPTgvvSBScGcBvfzmmLLCtMWNZRBQMzftf
tRFLmZZRLrtRvtvvrvvGgvtLNfwzMzNwgdznMpwwpnMpqHdz
hcsBsWTcQJhjbHMncNwzMqnzwl
VWSWWTJhWBVDTJsTVWQWTVVbZtCPSvrrGSLCRFRGtRZLPmmq
hbdFhdShGsFSGBlQhNhQMLLLlLJCvLLDtVJDLlwtwD
WcqWsmcWrmqcmtDHJjVHrJCjjt
WPWcnggssmzqzzzgfzZnWRqqdGpSNFdMSFdBMSFZhSFBZZhh
GNFNtRQMGjDjwfgDZjmz
bqDsPWWbsqVsdvvBJvBfmgfLLzSwzLcmzmfB
WPWrrVrrVJhVWJDVsqnPdRQllRQRNhQGMlFQFMplGl
mChChmSQGSGJrjPHCpPFtwgsFZjtFVZfgVwtdV
MBMqvDWMlTbzlRWzllDzblZfsrgdZffgrtwrswZfdZTd
DlcMvBbBMnqMDqcRqDBMWvLmCGrGLSJhnLHCCHHnPmSQ
tscfGqftGfDnnppJGDGCZLbzMVMwPPhsblzbjzzMMz
TWPTWWmHTmFRSBSvgBPwwwlVzhMdwblhbVjRLL
TTQNNWWgHWQHPBWTNPWNcqJtGCnfqfpQZJCZpQZn
CqzCGDQJCzzftfRqRzzMdvFpFpccdZFvFMtMbd
rNHwmHVmswsHVsPTLnbFSTbZZpFcpvSZZgpg
vPLhLLwHLhVVNVvQhBqDCBfhDzCffG
WsBbBbsWNhsPsCNssRWLPLpmLDDQHlJlnlzFnDDnzF
gcGfqggMqfjjGwrdDZzQFmpJQzZlFDMF
qdwqvjdTrwfvvBCPtpVvtR
RQdbbRHtHRvqZtwVcmwVwV
WnLNnqFDlDWzzNLLrjClwCZCGZcglGCccZ
LnTFfWBpffrfrhBqdsSBqhBJHb
sqsgJpDMrNQgGsFMsPCfjCPChPWjqSWSjh
RBnRnZVcwZllLwbwwLbZVLclhpjRttSdtjPhjWShWdphjCPd
HwHwVVwVnBVBmmGppNFzrrsgJJ
WpmDFlQlzmmgMMLMLQVTvTTSwNbmTVwTtHHw
jrhPDnDnnZfjPTNtHSVTcjccwt
CJqPfGnhGZCBfnPJCrBCqdLqMlQqDLlLRgLQFFRW
vZVvDZsvhDZhZvzgVcgVqPqmwWMqcw
bdTbdBBFQcdCdcGmcP
bmjQpHfbpzDJRjNhJZ
twRrwjFptprQjjjtQRdWCmNJTlNSCmZQcNlmlSST
VVDzMWDnDHMzLZDNNJSqqCJZZD
HHhhsfVHGbnwgjfrgdpgWj
GmszZGMrLmnmsfGVRcVlwtwccc
SSCgbNqSTgCCJMHCJtlVcwVbVljlclVfwf
HTCgHSgHQThMqWQQSgDnvBdsFDvrzdZsLdmLZZ
PRlMlBPPctVBlstzVLhsdwCqCdCNDjSDdWmMqdNw
fZrQQHFffgGFprSJSgvZrfnqjmWdnndCNGWmWDwNNDCG
rTvvpJZZrfpFSbQQvrrsssLRVPPtlRtRPThzTR
FqgHFFMRTRjRFRpRRjFtNdCtJCMnNNdrdMLdrQ
VhWSmwGwWVbGbvlwwlLZJLZSdJZtNCtnTSCJ
BmWwWWzhvVfwWhmhwlmvwlRqHpscHRTpTDRFfTsjDPjD
MJMgGqMFLPGgWVjpcmjZTpmZjZpJ
hdSzzlCtzNdtWSdndttflBmjpBRmvvpjnjcvBjmvHj
zdhCrfztrDSzfWzdChrhlhgPPPGDgqFFLGGFVVqqPVQw
ZQZNQRZzFdCCgfLcCGDfScjDcG
vsmwVHTmTfGcSHjcDS
tMsmMVlSWWzdWNnQNJ
GPRcQnwwQWwFFnrnnldSqzMfSCdfdldrJf
LpTsjmZTsBZjpmzhLLMdSJJSMhCC
ZsZBssBsDpDmmVBjCmDZHgnVNWvPQPNPGvNQncQPcRWn
pznzpzlGFrvGHGrnnMvDmBMfgfTmsBsTTghDsg
LJtWVCWLCNPcSbdcShWBgBThgTfjzwfhhz
VZZCdLCVNNCVbCLzFnRqGqlHprQZHRqr
dFTsQPdMFsMnWFPdSnwBltftttvlflNN
VLZhZLqghCgzqgrLrcgVgbCvtDDtwpqNpDtlBRflDwNqDpNw
cLmVhVcgbZrVhrhCLhczhQdJHTmPJJTjvTJsPFWFTW
SSwNPNHldNJSngHqBssQvBfccB
mMppmDprWpFGRGWmWrDrtGzQfcvvQZBBzzczqRQgRqRT
WtFtFvhvpLphNJJVSCbSNP
chpGMMzcwSSGnQFRQQFWcFWn
sgddTfjLqsWrRtLvQnJr
CsmlZgssbRdMhzCHDGpGGG
vHBrTzpMPTHMtbBRRJGtDsNB
QJWWVwnCZmQlWQWlLWCCmmLwRgtDdDbgngqtRdRGbDNDGtGq
LwmWQLJcWmwPrpvpjjrcjT
fcsWnWzhWcWgcbfbvtbHTRvpvHttmLtR
lNSjwjrDFjlFhlZlQTpLHvSHptvTSRtLmJ
NwjwrQDwFCZBCfWzqhqqzc
fgNJNRcvvWRfWRrZFldlwlFwfFllflDH
spQshQhpqhJsLpnQVLqBqlFwddHSdBFFjSFmwlFmwl
hppLsqPVLnpnzJPtqtPPJTCgNcrcNbrrGNcgRNrzcZbG
PWFdgDGCFPGhMtQqHBrpJqqW
nlllLNmnVNNLllVbVRLRsQMqqpccQQJcJtqcJcnBrc
NmvZLsNrbZNjNZVNGvdFFfwdDhPFdDzC
LpZpwgLsLSzDdjVGpS
bWBlHqqBhNJWNbJQFzGtCtDtGGjNGDgtGC
RBRbJggbWRRmhWqTcnnfnmZMTTsTcP
JJgzvfzpdzzJjJhgdfhvqfdScNsLwwGsrRbwRLbcbVrVRp
WDFBTTDtHTntltnCnnntCDwGlGGbSwNVSssrbwGVsVLs
nCHMDtCWWTCCHmmPDnZQgvfQgZNJJdvdMZQg
lFDgvlsGvvZGDsFZWgGvWrPqnmwwtqmMVSWrSqMM
hRpJhLQHhdTTVPmVSrqwtHmV
ctJJJfjLpjglZDGCGljF
CnnVMbhVRbQQZjBP
rlfsLFLtmLSJscttFfsdjZwZNNwBPWRjRNZBZBfQ
tFrmDFlDtmcltFvqVzDqQzGvCVCG
JzzJzVrmzJpCCmTFmjZS
HtDDtggWssqWfDgwDWvsfDBBchZjSnGGpCFjSFZjpGjFShZg
sbvbvfbbDblWtrNVNRzRlJPCzM
nlFnFWsWhrctWVdJPDPTnTNJPJQJ
fHqvHSqRqSHjBmqvmqqHCtJSTZGdMQJDPQDPPMdNTMZN
jzqmbtRRztmbLHcFpgWVsFphpcLV
PHZFZFVZZfHgpwjFtmgjtq
rpTrTNzzNdrTJwgMwqCBJzJz
vsTWbvccRcdRbrRnRRbRrcvVpGlGHZPspSVhSPPQGGZVHV
HWnDDjfPFccDPhfchnMMVWGzzpvGszCCGWWV
JNBtBTQJNwJQjTpRVRMvpLsQzsRR
JltNSrBjmrHfdPHnDlHg
ldCJHlZFspjzHMnp
zvcLQBQcQvhBwmcDppqbNpjMLnLDDn
BvcmQhWWRzPJJzWWWg
ggSTPZBwTPTPSTRwZPBnwPMLdVvBqzsqLzqqtVzqtzBszN
QRmhQhffCQhJcDfmpChQWJmJNNtzvqtLdvNsGtLqNGzvWqvG
HQFCDhDFCCQJQmZTZwTSSwrZnRFS
QbFlsMbgPWPlJWzsJsJZntvnvZtctHBfZvBZlD
VTqpTqmSrhVLqrpjNppgntfBgfjddHffZBdtcB
VCwpqqqNVgNVgMJJwbsWWGMGFR
GCwRjQlsCQrPrGMQPsRvpdvgnjgmVVmSStptgJ
DzNcZNHZZhzzHhDzDTLWhDzSdJSSpnnVSTSvJJmgvSdmmn
pfLNDppNWHqDWfWbzcHPRslCGbwRCPwQrGQPCF
hVLnDgCmbhltrmDlhbhVmcgFBWdSBSZZBFPwBLBPfWdPWZ
TNTjJNpjqGMTRRsTTCZddfWwFHFWHSSJSFPS
CGQqvQRTNzTpQsDtmcrgDQllhnQl
SWrtcHWjcWrPcwWrBwSPffnJNsqfMNCNqNfJFfSq
QLQvhBpbbvdvTdvpTdGDbDQqqqslsNMJlMMCqMfQnlfC
gThhpmDLbzBmGLptrmRZcwHWHZjVrW
gQvzQRvSSbvvJvQgfRrfbSpGqBPGwqwVjPBBwwjpRmjB
TcNHHVVtNsDHcMcdMBjqpBnGnwlGTwlPBl
MHsMDHFMdDtZddZdFdFrhhgbFFVvffrzzffrrS
QSFmrDSSQrqlfmDDHPRTdrrTPRbsTPTsNN
wBcclhhgwgMhWLLtVMgVvzRTNNjvbszzTdjNdsRbjp
nJgVMtBhwLBctmQHQlnCGqmQZZ
sggtjzzggfGmPbCMvRCMvTmT
RDqqhdQdDlcDpqVlLbSbZFSTTPllbCMv
hqpQWRhhdncDQcBsrwzjnfgtgGfgHs
MTrzlgMNQNggrrrPlzQDPCsFRfscTfFVhVftRsFFsScS
nWWHZHhZWJjjwjLjwbLbwHGSFppVfFVcGcFLfFSVttpf
jWhZZBhqBbwvZvBjZNNQrQQQzPMlzzglPB
jLVhJZQjwFCLRjQhPRZFLDzrGDHpDGsGqztGHststC
SBNlNmWnfvdLmlnvfNSbzrDTTzprdqrDpGqqpHrG
bNmSBnBmcfMmcmnlfcnNSnLhZPVVJhwjZRJPwjZMPjMZ
VpzBDgGTGVNNpSGzppMdTQwcvFdFMQdcdFwc
ZDsqfRftWtllmlWbLLtjFFMwMrjCcwfvMFvwcC
PHbDLHZtZJSJPpVgnV
bRvTdswLLSTvwswSbDhsDTvFmmGRVmJGZJnRcGGfFVJcqn
MWllQMllWHrjWPNplrllQMPZJmnnVmqJcNmVFFnJNFqVGC
PgpQrQjjzQWHzpBdvtwhwdSShBZTsT
MhTwjMTsTRFStjmSMqqppBrHpDrzHtPqbD
dllNcZWgldLvcsvvvvgvWddlHffqBHBBfPzbbqBpPHrpHNbq
VddvgWWdCZhnhsCSSCGT
LPjqHnDNqqHNllqLpqPCZCGRCssGdGrGFrPrgr
WVBztWTQSQMBQrGgRwwwCGgtwg
QJMTgvbTTWSzWWvSbVJTzJllJlHHhLpNqpHqjNjNHpjq
PCHCbPPPHPlTThBhjGTTNhMNTh
FrmfLqdqgfmfttqtWqfrqdhshchDBshDllDBcGDhGDWs
mqgdpvFmmdLdqqQCPHZZblvwZQZl
bQGqmngwwgSNrBWJWdHZmjfZWB
FlpRLCptFLMlLPRLlCCcCCMpjJZJHShWdWvBHHdcZdBWZvSv
FRPCDTTtFptVTnQnrGbwbS
LsdmnDMTLbzsbNtqcb
lJjCnHSvQRRwQQjRRHQbgWbqctNJPbcWrcPPgc
RhGSQGwBvvGShnGlHClwjmfpmfdmVmfFDBLDDZpmMf
ppDnPmwvNDjTjjcssT
qqfRHzdCPHWfhHHtTjjbbLLGZr
MhzqWdJCzqJWSJnpnpvvPSPP
NGWdQgDDHGJgQLznzzsJFFzvzB
twRCpZVjVWqVSqVwwjtZfrrfntfvznBssBncfLrc
jRRwCqwCZhlhZRpSZpjSqWwqmDMQdMmHPQQMHGdlHdTldNGd";
}
