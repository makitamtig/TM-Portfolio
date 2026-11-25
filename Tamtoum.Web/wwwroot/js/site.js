
document.addEventListener("DOMContentLoaded", () => {

    const menuToggle = document.getElementById("menuToggle");
    const navLinks = document.getElementById("navLinks");

    if (!menuToggle || !navLinks) return;

    function closeMenu() {
        navLinks.classList.remove("open");
        menuToggle.setAttribute("aria-expanded", "false");
        menuToggle.setAttribute("aria-label", "Open navigation");
    }

    menuToggle.addEventListener("click", () => {

        const isOpen = navLinks.classList.toggle("open");

        menuToggle.setAttribute("aria-expanded", String(isOpen));
        menuToggle.setAttribute(
            "aria-label",
            isOpen ? "Close navigation" : "Open navigation"
        );
    });

    navLinks.querySelectorAll("a").forEach(link => {
        link.addEventListener("click", closeMenu);
    });

    document.addEventListener("keydown", event => {
        if (event.key === "Escape") closeMenu();
    });

});




document.addEventListener("DOMContentLoaded", function () {

    // VIDEO GALLERY
    document.querySelectorAll("[data-video-gallery]").forEach(function (gallery) {

        const mainVideo = gallery.querySelector(".main-gallery-video");
        const mainTitle = gallery.querySelector(".main-video-title");
        const thumbnails = gallery.querySelectorAll(".video-thumbnail");

        thumbnails.forEach(function (thumbnail) {

            thumbnail.addEventListener("click", function () {

                const videoSrc = thumbnail.dataset.videoSrc;
                const poster = thumbnail.dataset.videoPoster;
                const title = thumbnail.dataset.videoTitle;

                if (!videoSrc) return;

                mainVideo.pause();

                mainVideo.src = videoSrc;
                mainVideo.poster = poster || "";

                mainVideo.load();

                mainTitle.textContent = title || "";

                thumbnails.forEach(function (item) {
                    item.classList.remove("active");
                });

                thumbnail.classList.add("active");

                mainVideo.play().catch(function () {
                    // Browser may require the user to press Play.
                });
            });

        });
    });


    // IMAGE GALLERY
    document.querySelectorAll("[data-image-gallery]").forEach(function (gallery) {

        const mainImage = gallery.querySelector(".main-gallery-image");
        const thumbnails = gallery.querySelectorAll(".image-thumbnail");

        thumbnails.forEach(function (thumbnail) {

            thumbnail.addEventListener("click", function () {

                const imageSrc = thumbnail.dataset.imageSrc;

                if (!imageSrc) return;

                mainImage.src = imageSrc;

                thumbnails.forEach(function (item) {
                    item.classList.remove("active");
                });

                thumbnail.classList.add("active");

            });

        });
    });

});



document.addEventListener("DOMContentLoaded", function () {

    const dialog = document.getElementById("imageLightbox");

    if (!dialog) return;

    const preview = document.getElementById("lightboxImage");
    const counter = document.getElementById("lightboxCounter");
    const titleEl = document.getElementById("lightboxTitle"); // <-- 1. ADD THIS

    const closeBtn = document.getElementById("lightboxClose");
    const prevBtn = document.getElementById("lightboxPrev");
    const nextBtn = document.getElementById("lightboxNext");

    let galleryImages = [];
    let currentIndex = 0;
    let mainImage = null;
    let mainImageTitle = null; // <-- 2. ADD THIS (to also update the title below mainImage)
    let lastFocusedElement = null;

    function updateGallery() {

        if (!galleryImages.length) return;

        const selectedImage = galleryImages[currentIndex];
        const imageSrc = selectedImage.dataset.imageSrc;
        const imageTitle = selectedImage.dataset.imageTitle || "Project image"; // <-- 3. READ TITLE
        const thumbnailImage = selectedImage.querySelector("img");

        preview.src = imageSrc;
        preview.alt = imageTitle;

        // Update the title inside the lightbox
        if (titleEl) {
            titleEl.textContent = imageTitle;
        }

        // Also update the large image & title behind the lightbox
        if (mainImage) {
            mainImage.src = imageSrc;
            mainImage.alt = preview.alt;
        }
        if (mainImageTitle) {
            mainImageTitle.textContent = imageTitle;
        }

        counter.textContent =
            String(currentIndex + 1).padStart(2, "0") +
            " / " +
            String(galleryImages.length).padStart(2, "0");

        const multiple = galleryImages.length > 1;

        prevBtn.hidden = !multiple;
        nextBtn.hidden = !multiple;
    }

    function openGallery(gallery, index, trigger) {

        galleryImages = Array.from(
            gallery.querySelectorAll("[data-gallery-image]")
        );

        if (!galleryImages.length) return;

        mainImage = gallery.querySelector(".main-gallery-image");
        mainImageTitle = gallery.querySelector(".gallery-image-title"); // <-- 4. GRAB MAIN TITLE ELEMENT
        currentIndex = index;
        lastFocusedElement = trigger;

        updateGallery();

        dialog.showModal();
        closeBtn.focus();
    }

    function closeGallery() {

        dialog.close();

        if (lastFocusedElement) {
            lastFocusedElement.focus();
        }
    }

    function nextImage() {

        if (!galleryImages.length) return;

        currentIndex =
            (currentIndex + 1) % galleryImages.length;

        updateGallery();
    }

    function previousImage() {

        if (!galleryImages.length) return;

        currentIndex =
            (currentIndex - 1 + galleryImages.length)
            % galleryImages.length;

        updateGallery();
    }

    // Make the main image and every thumbnail clickable
    document.querySelectorAll("[data-image-gallery]")
        .forEach(function (gallery) {

            const items = gallery.querySelectorAll(
                "[data-gallery-image]"
            );

            items.forEach(function (item, index) {

                item.addEventListener("click", function () {

                    openGallery(gallery, index, this);

                });

            });

        });

    closeBtn.addEventListener("click", closeGallery);

    nextBtn.addEventListener("click", nextImage);

    prevBtn.addEventListener("click", previousImage);

    // Close when clicking outside the image
    dialog.addEventListener("click", function (event) {

        if (event.target === dialog) {
            closeGallery();
        }

    });

    // Keyboard navigation
    document.addEventListener("keydown", function (event) {

        if (!dialog.open) return;

        if (event.key === "ArrowRight") {
            event.preventDefault();
            nextImage();
        }

        if (event.key === "ArrowLeft") {
            event.preventDefault();
            previousImage();
        }

    });

    dialog.addEventListener("close", function () {
        galleryImages = [];
        mainImage = null;
        mainImageTitle = null;
    });

});

document.addEventListener("DOMContentLoaded", function () {

    const lightbox = document.getElementById("projectLightbox");
    const mainImage = document.getElementById("lightboxMainImage");
    const titleElement = document.getElementById("lightboxTitle");
    const counter = document.getElementById("lightboxCounter");
    const gallery = document.getElementById("lightboxGallery");

    const closeBtn = document.getElementById("lightboxClose");
    const prevBtn = document.getElementById("lightboxPrev");
    const nextBtn = document.getElementById("lightboxNext");

    const projectImages = [
        ...document.querySelectorAll(
            "#upcoming-projects .upcoming-featured-image img, " +
            "#upcoming-projects .upcoming-card-image img"
        )
    ];

    let currentIndex = 0;

    const projects = projectImages.map((img, index) => {

        const card = img.closest(".upcoming-project-card");

        const title = card
            ? card.querySelector(".upcoming-card-content h3")?.textContent.trim()
            : document.querySelector(
                ".upcoming-featured-image .featured-project-overlay h3"
            )?.textContent.trim();

        return {
            src: img.currentSrc || img.src,
            title: title || img.alt || `Project ${index + 1}`
        };

    });

    // Create all thumbnails
    projects.forEach((project, index) => {

        const thumbnail = document.createElement("button");

        thumbnail.className = "lightbox-thumb";

        thumbnail.innerHTML = `
            <img src="${project.src}" alt="">
            <span>${project.title}</span>
        `;

        thumbnail.addEventListener("click", function () {
            showProject(index);
        });

        gallery.appendChild(thumbnail);

    });

    function showProject(index) {

        if (!projects.length) return;

        currentIndex = (index + projects.length) % projects.length;

        const project = projects[currentIndex];

        mainImage.src = project.src;
        mainImage.alt = project.title;

        titleElement.textContent = project.title;

        counter.textContent =
            `${String(currentIndex + 1).padStart(2, "0")} / ${String(projects.length).padStart(2, "0")}`;

        document.querySelectorAll(".lightbox-thumb").forEach(
            (thumb, i) => {
                thumb.classList.toggle("active", i === currentIndex);
            }
        );

    }

    // Open gallery when clicking any project image
    projectImages.forEach((img, index) => {

        img.style.cursor = "zoom-in";

        img.addEventListener("click", function () {

            showProject(index);

            lightbox.classList.add("active");
            lightbox.setAttribute("aria-hidden", "false");

            document.body.classList.add("lightbox-open");

        });

    });

    // Close gallery
    function closeGallery() {

        lightbox.classList.remove("active");
        lightbox.setAttribute("aria-hidden", "true");

        document.body.classList.remove("lightbox-open");

    }

    closeBtn.addEventListener("click", closeGallery);

    lightbox.addEventListener("click", function (e) {

        if (e.target === lightbox) {
            closeGallery();
        }

    });

    // Navigation
    prevBtn.addEventListener("click", function () {
        showProject(currentIndex - 1);
    });

    nextBtn.addEventListener("click", function () {
        showProject(currentIndex + 1);
    });

    // Keyboard navigation
    document.addEventListener("keydown", function (e) {

        if (!lightbox.classList.contains("active")) return;

        if (e.key === "Escape") closeGallery();

        if (e.key === "ArrowRight") {
            showProject(currentIndex + 1);
        }

        if (e.key === "ArrowLeft") {
            showProject(currentIndex - 1);
        }

    });

});



//document.addEventListener("DOMContentLoaded", function () {

//    const dialog = document.getElementById("imageLightbox");

//    if (!dialog) return;

//    const preview = document.getElementById("lightboxImage");
//    const counter = document.getElementById("lightboxCounter");

//    const closeBtn = document.getElementById("lightboxClose");
//    const prevBtn = document.getElementById("lightboxPrev");
//    const nextBtn = document.getElementById("lightboxNext");

//    let images = [];
//    let currentIndex = 0;
//    let lastFocusedElement = null;

//    function updateGallery() {

//        if (!images.length) return;

//        preview.src = images[currentIndex].dataset.imageSrc;

//        preview.alt = images[currentIndex].querySelector("img").alt;

//        counter.textContent =
//            String(currentIndex + 1).padStart(2, "0") +
//            " / " +
//            String(images.length).padStart(2, "0");

//        const multiple = images.length > 1;

//        prevBtn.hidden = !multiple;
//        nextBtn.hidden = !multiple;
//    }

//    function openGallery(button) {

//        const gallery = button.closest(".image-gallery");

//        images = Array.from(
//            gallery.querySelectorAll("[data-gallery-image]")
//        );

//        currentIndex = images.indexOf(button);

//        lastFocusedElement = button;

//        updateGallery();

//        dialog.showModal();

//        closeBtn.focus();
//    }

//    function closeGallery() {

//        dialog.close();

//        if (lastFocusedElement) {
//            lastFocusedElement.focus();
//        }
//    }

//    function nextImage() {

//        if (!images.length) return;

//        currentIndex = (currentIndex + 1) % images.length;

//        updateGallery();
//    }

//    function previousImage() {

//        if (!images.length) return;

//        currentIndex =
//            (currentIndex - 1 + images.length) % images.length;

//        updateGallery();
//    }

//    document.querySelectorAll("[data-gallery-image]")
//        .forEach(button => {

//            button.addEventListener("click", function () {
//                openGallery(this);
//            });

//        });

//    closeBtn.addEventListener("click", closeGallery);

//    nextBtn.addEventListener("click", nextImage);

//    prevBtn.addEventListener("click", previousImage);

//    dialog.addEventListener("click", function (event) {

//        if (event.target === dialog) {
//            closeGallery();
//        }

//    });

//    dialog.addEventListener("close", function () {
//        images = [];
//    });

//    document.addEventListener("keydown", function (event) {

//        if (!dialog.open) return;

//        if (event.key === "ArrowRight") {
//            event.preventDefault();
//            nextImage();
//        }

//        if (event.key === "ArrowLeft") {
//            event.preventDefault();
//            previousImage();
//        }

//    });

//});
