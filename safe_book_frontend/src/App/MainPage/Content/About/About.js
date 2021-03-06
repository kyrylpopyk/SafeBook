import about from "./Abount.module.css";

const About = () => {

    const showMainDesc = (e) => {
        document.querySelector(`.${about.descriptionHideLeft}`).classList.add(about.leftHideToAdd);
        document.querySelector(`.${about.descriptionHideRight}`).classList.add(about.rightHideToAdd);
        document.querySelector(`.${about.descriptionHideTitle}`).classList.add(about.titleHideToAdd);
    }

    const showSecDesc = () => {
        let topBubble = document.querySelector(`.${about.topBubble}`);
        if(topBubble.classList.contains(about.topBubbleShowCall)){
            let bubbleElemList = document.querySelector(`.${about.mainBubbleContent}`).children;
            for(let elem of bubbleElemList){
                elem.classList.remove(elem.classList[2]);
            }
            let allSubBubble = document.querySelectorAll(".bubble");
            for(let elem of allSubBubble){
                if(elem.classList.contains("activeBubble")){
                    elem.style.height = "150px";
                    elem.style.width = "150px";
                    elem.classList.remove("activeBubble");
                    elem.querySelector("div").style.display = "none";
                    setTimeout( () => {
                        elem.querySelector("span").style.display = "block";
                    }, 500)
                }
            }
        }
        else{
            topBubble.classList.add(about.topBubbleShowCall);
            document.querySelector(`.${about.topLeftBubble}`).classList.add(about.topLeftBubbleShowCall);
            document.querySelector(`.${about.leftBubble}`).classList.add(about.leftBubbleShowCall);
            document.querySelector(`.${about.leftBottomBubble}`).classList.add(about.leftBottomBubbleShowCall);
            document.querySelector(`.${about.bottomBubble}`).classList.add(about.bottomBubbleShowCall);
            document.querySelector(`.${about.bottomRightBubble}`).classList.add(about.bottomRightBubbleShowCall);
            document.querySelector(`.${about.rightBubble}`).classList.add(about.rightBubbleShowCall);
            document.querySelector(`.${about.topRightBubble}`).classList.add(about.topRightBubbleShowCall);

        }
    }

    async function onClickSubBubble(e){
        let curElem = e.target;
        while(!curElem.classList.contains("bubble")){
            curElem = curElem.parentElement;
        }
        if(curElem.classList.contains("activeBubble")){
            curElem.style.height = "150px";
            curElem.style.width = "150px";
            curElem.classList.remove("activeBubble");
            curElem.querySelector("div").style.display = "none";
            setTimeout( () => {
                curElem.querySelector("span").style.display = "block";
            }, 500)
        }
        else{
            let allSubBubble = document.querySelectorAll(".bubble");
            for(let elem of allSubBubble){
                if(elem !== curElem && elem.classList.contains("activeBubble")){
                    elem.style.height = "150px";
                    elem.style.width = "150px";
                    elem.classList.remove("activeBubble");
                    elem.querySelector("div").style.display = "none";
                    setTimeout( () => {
                        elem.querySelector("span").style.display = "block";
                    }, 500)
                }
            }
            curElem.classList.add("activeBubble");
            curElem.style.height = "250px";
            curElem.style.width = "250px";
            setTimeout( () => {
                if(curElem.classList.contains("activeBubble")){
                    curElem.querySelector("span").style.display = "none";
                    curElem.querySelector("div").style.display = "block";
                }
            }, 500)
        }
    }
    
    
    return(
        <div className={about.content}>
            <div className={about.title}>
                <img className={about.titleBackground} alt="" src={process.env.PUBLIC_URL + '/Clouds.jpg'}/>
                <div className={about.titleContent}>
                    <div className={about.titleContentMain}>PATRTYTURA</div>
                    <div className={about.titleContentSub}>Kr??tko o nas</div>
                </div>
            </div>
            <div className={about.descriptionMain} onClick={showMainDesc}>
                <div className={about.descriptionMainTitle}>Og??lne</div>
                <div className={about.descriptionMainDesc}>
                    Stowarzyszenie powsta??o w 2021 roku, zrzeszaj??c ludzi kultury: kompozytor??w, 
                    dyrygent??w, instrumentalist??w i wokalist??w. Naszym g????wnym celem jest organizacja 
                    wydarze?? o charakterze kulturalnym i edukacyjnym na terenie Ma??opolski. 
                    Nasze wydarzenia s?? skierowanie do szerokiego grona odbiorc??w w ka??dej grupie 
                    wiekowej, maj??ce na celu popularyzacje wybitnych dzie?? wsp????czesnych kompozytor??w i uwra??liwianie na muzyk??.
                </div>
                <div className={about.descriptionHide}>
                    <div className={about.descriptionHideLeft}></div>
                    <div className={about.descriptionHideRight}></div>
                    <div className={about.descriptionHideTitle}>
                        <div className={about.descriptionHideTitleMain}>O nas</div>
                        <div className={about.descriptionHideTitleSub}>(Naci??nij)</div>
                    </div>
                </div>
            </div>
            <div className={about.descriptionBubble}>
                <div className={about.mainBubble} onClick={showSecDesc}>
                    <div className={about.mainBubbleText}>Cele</div>
                </div>
                <div className={about.mainBubbleContent}>
                        <div className={`${about.rightBubble} bubble`} onClick={onClickSubBubble}>
                            <span>??YCIE</span>
                            <div className={about.hidenBubbleText}>
                                Aktywny udzia?? w ??yciu spo??ecznym i kulturalnym regionu i kraju.
                            </div>
                        </div>
                        <div className={`${about.topRightBubble} bubble`} onClick={onClickSubBubble}>
                            <span>WYDAWNICTWO</span>
                            <div className={about.hidenBubbleText}>
                                Wydawnictwo p??yt, ksi????ek, czasopism, nut.
                            </div>
                        </div>
                        <div className={`${about.topBubble} bubble`} onClick={onClickSubBubble}>
                            <span className={about.topBubbleText}>ANGA??OWANIE</span>
                            <div className={`${about.hidenBubbleText} ${about.colorWhite}`}>
                                Anga??owanie dzieci i m??odzie??y w dzia??alno???? artystyczn??.
                            </div>
                        </div>
                        <div className={`${about.topLeftBubble} bubble`} onClick={onClickSubBubble}>
                            <span className={about.colorWhite}>PROMOWANIE</span>
                            <div className={`${about.hidenBubbleText} ${about.colorWhite}`}>
                                Promowanie profesjonalnej dzia??alno??ci artystycznej o zasi??gu lokalnym, krajowym i mi??dzynarodowym.
                            </div>
                        </div>
                        <div className={`${about.leftBubble} bubble`} onClick={onClickSubBubble}>
                            <span>ORGANIZACJA</span>
                            <div className={about.hidenBubbleText}>
                                Organizowanie konferencji, seminari??w, szkole?? i wyk??ad??w, 
                                imprez kulturalnych, koncert??w, prapremier, festiwali, wernisa??y, 
                                przedstawie?? teatralnych.
                            </div>
                        </div>
                        <div className={`${about.leftBottomBubble} bubble`} onClick={onClickSubBubble}>
                            <span className={about.colorWhite}>WSPARCIE</span>
                            <div className={`${about.hidenBubbleText} ${about.colorWhite}`}>
                                Realizacj?? i wspieranie finansowe przedsi??wzi???? i projekt??w (tak??e o charakterze ci??g??ym) o zasi??gu lokalnym, krajowym i mi??dzynarodowym.
                            </div>
                        </div>
                        <div className={`${about.bottomBubble} bubble`} onClick={onClickSubBubble}>
                            <span className={about.colorWhite}>ROZW??J</span>
                            <div className={`${about.hidenBubbleText} ${about.colorWhite}`}>
                                Wspieranie rozwoju kariery m??odych muzyk??w, w tym kompozytor??w, dyrygent??w, wokalist??w i instrumentalist??w.
                            </div>
                        </div>
                        <div className={`${about.bottomRightBubble} bubble`} onClick={onClickSubBubble}>
                            <span className={about.bottomRightBubbleText}>WSP????PRACA</span>
                            <div className={`${about.hidenBubbleText} ${about.colorWhite}`}>
                                Wsp????prac?? ze szko??ami i uczelniami wy??szymi, samorz??dami, organizacjami pozarz??dowymi, mediami.
                            </div>
                        </div>
                    </div>
            </div>
            <div className={about.thanks}>
                <div className={about.thanksContentMain}>
                    Dzi??ki Pa??stwa wsparciu b??dziemy mogli organizowa?? przede wszystkim koncerty solowe, 
                    kameralne, symfoniczne i ch??ralne, do kt??rych dost??p b??dzie mia??o szerokie grono odbiorc??w.
                </div>
                <div className={about.thanksContentSub}>
                    Starannie dobieramy program wszelkich wydarze??, by zainteresowa?? s??uchacza i by?? atrakcyjny w odbiorze.
                </div>
            </div>
        </div>
    );
}

export default About;